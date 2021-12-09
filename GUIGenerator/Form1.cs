namespace GUIGenerator
{
    using exYuUBLGenerator;
    using exYuUBLGenerator.Cac;
    using exYuUBLGenerator.Udt;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        public static MockData GetData()
        {
            return new MockData
            {
                IDdokumenta = "1234-2020/DOK",
                DatumIzdavanja = DateTime.Now,
                VrijemeIzdavanja = "09:50:00",
                VeznaOznaka = "Vezna oznaka - neka",
                VeznaOznakaDatum = DateTime.Now.AddDays(1),
                GLNpartnerDobavljaca = "Dob_GLN 12345",
                NazivDobavljaca = "Moj dobavljač",
                UlicaDobavljaca = "Ulica dobavljača 22",
                GradDobavljaca = "Beograd",
                PostanskiBrojDobavljaca = "11111",
                PunaAdresaDobavljaca = "Ulica dobavljača 22, 11111, Beograd",
                OznakaDrzaveDobavljaca = "RS",
                NazivDrzaveDobavljaca = "Republika Srbija",
                IDbrojDobavljaca = "PIB ili ID broj",
                GLNDostavnePartnerLokacije = "GLN Partner Lokacije",
                NazivDostavnePartnerLokacije = "Naziv Partner Lokacije",
                UlicaDostavnePartnerLokacije = "Ulica partner lokacije 22",
                GradDostavnePartnerLokacije = "Grad lokacije",
                PostanskiBrojDostavnePartnerLokacije = "12345",
                PunaAdresaDostavnePartnerLokacije = "Ulica partner lokacije 22, 12345, Grad lokacije",
                OznakaDrzaveDostavnePartnerLokacije = "RS",
                NazivDrzaveDostavnePartnerLokacije = "Republika Srbija",
                IDbrojDostavnePartnerLokacije = "PIB ili ID broj Lokacije",
                GLNKupca = "GLN kupca",
                NazivKupca = "Naziv kupca",
                UlicaKupca = "Ulica kupca 33",
                GradKupca = "Grad",
                PostanskiBrojKupca = "56789",
                PunaAdresaKupca = "Ulica kupca 33, 56789, Grad",
                OznakaDrzaveKupca = "RS",
                NazivDrzaveKupca = "Republika Srbija",
                IDbrojKupca = "PIB ili ID broje Kupca",
                DatumDostave = DateTime.Now.AddDays(7),
                IDbrojStavke = "1",
                JedinicaMjere = "kom",
Kolicina = 2M,
VeznaOznakaStavke = "Veži na stavku",
NazivProizvoda = "Super proizvod",
InternaOznakaProizvoda = "1234566",
BarkodProizvoda = "3871234567890",
BrojSerijeProizvoda = "1111-11",
NettoCijenaStavke = 22.22M,
Valuta = "RSD ili BAM ili HRK",
TotalCijenaStavke = 44.22M,
IstekSerijeProizvoda = DateTime.Now.AddYears(1),
BrojPakiranja = "",
            };
        }
        public static StockAvailabilityReportType StanjeZalihaSrbija()
        {
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID = "9" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };
            var data = GetData();
            StockAvailabilityReportType res = new StockAvailabilityReportType
            {
                UBLVersionID = "2.1",
                ID = data.IDdokumenta,
                IssueDate = data.DatumIzdavanja,
                IssueTime = data.VrijemeIzdavanja,
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint(data.GLNpartnerDobavljaca),
                        PartyName = new[] { new PartyNameType { Name = data.NazivDobavljaca } }
                    }
                },
                RetailerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint(data.GLNKupca),
                        PartyName = new[] { new PartyNameType { Name = data.NazivKupca } }
                    }
                },
                InventoryReportingParty = new PartyType
                {
                    EndpointID = attEndpoint(data.GLNDostavnePartnerLokacije),
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = data.NazivDostavnePartnerLokacije
                        }
                    },
                },
                StockAvailabilityReportLine = new StockAvailabilityReportLineType[]
                {
                    new StockAvailabilityReportLineType
                    {
                        ID = data.IDbrojStavke,
                        Quantity = new QuantityType
                        {
                            unitCode = data.JedinicaMjere,
                            Value = data.Kolicina
                        },
                        ValueAmount = new AmountType
                        {
                            currencyID = "RSD",
                            Value = data.TotalCijenaStavke
                        },
                        Item = new ItemType
                        {
                            Name= data.NazivProizvoda,
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = data.InternaOznakaProizvoda
                            },
                            AdditionalItemIdentification = new ItemIdentificationType[]

                            { new ItemIdentificationType{
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                            Value = data.BarkodProizvoda
                                }
                            } }
                        }
                    },
                    new StockAvailabilityReportLineType
                    {
                        ID = "2",
                        Quantity = new QuantityType
                        {
                            unitCode = "KGM",
                            Value = 150M
                        },
                        ValueAmount = new AmountType
                        {
                            currencyID = "RSD",
                            Value = 71.05M
                        },
                        Item = new ItemType
                        {
                            Name= "IME PROIZVODA",
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "289601"
                            },
                            AdditionalItemIdentification = new ItemIdentificationType[]

                            { new ItemIdentificationType{
                                ID = new IdentifierType
                                {
                                    schemeID = "GTIN",
                            Value = "BARKOD"
                                }
                            } }
                        }
                    },
                }
            };
            return res;
        }

        private static OrderResponseSimpleType PotvrdaPrijemaNarudzbeniceSrbija()
        {
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID = "9" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };

            OrderResponseSimpleType res = new OrderResponseSimpleType
            {
                UBLVersionID="2.1",
                ID= "POTV111222",
                IssueDate = new DateTime(2020, 4, 25),
                IssueTime = "09:45:00",
                AcceptedIndicator = true,
                OrderReference =  new OrderReferenceType
                {
                    ID = "NR562/2222",
                    IssueDate = new DateTime(2020, 4, 25)
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN DOBAVLJAČA"),
                        PartyName = new[] { new PartyNameType { Name = "Dobavljač d.o.o." } }
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN KUPCA"),
                        PartyName = new[] { new PartyNameType { Name = "Kupac d.o.o." } }
                    }
                },
            };
            return res;
        }

        private static ReceiptAdviceType PotvrdaPrijemaSrbija()
        {
            // custom attributes
            Func<decimal, AmountType> attAmountType = v => new AmountType { Value = v, currencyID = "RSD" };
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID = "9" };
            Func<string, IdentifierType> attAdditionalItemId = v => new IdentifierType { Value = v, schemeID = "GTIN" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };
            Func<string, CodeType> attDeliveryIdCode = v => new CodeType { Value = v, listAgencyID = "6", listAgencyName = "United Nations Economic Commission for Europe", listID = "ISO3166-1", listName = "Country", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listVersionID = "0.3", name = "String" };
            Func<string, IdentifierType> attTransportHandlingUnitID = v => new IdentifierType { Value = v, schemeID = "SSCC", schemeAgencyID = "9" };


            ReceiptAdviceType rec = new ReceiptAdviceType
            {
                UBLVersionID = "2.1",
                ID = "PR111222",
                IssueDate = new DateTime(2020, 4, 25),
                IssueTime = "15:31:15",
                OrderReference = new[] { new OrderReferenceType
                {
                    ID = "NR562/2222",
                    IssueDate = new DateTime(2020, 4, 25)
                }
                },
                DespatchDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "OT111222",
                        IssueDate = "2020-04-25"
                    }
                },
                DeliveryCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("GLN DOSTAVNOG MESTA"),
                        PartyName = new[] { new PartyNameType { Name = "Naziv dostavnog mesta" } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica dostavnog mesta",
                            BuildingNumber = "3",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Adresa mesta dostave 3, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[] { new PartyLegalEntityType
                        {
                            RegistrationName = "Naziv dostavnog mesta",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },
                DespatchSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN DOBAVLJAČA"),
                        PartyName = new[] { new PartyNameType { Name = "Dobavljač d.o.o." } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica dobavljača",
                            BuildingNumber = "1",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Ulica dobavljača 1, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[] { new PartyLegalEntityType
                        {
                            RegistrationName = "Dobavljač d.o.o.",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },

                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN KUPCA"),
                        PartyName = new[] { new PartyNameType { Name = "Kupac d.o.o." } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica kupca",
                            BuildingNumber = "2",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Ulica kupca 2, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[] { new PartyLegalEntityType
                        {
                            RegistrationName = "Kupac d.o.o.",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },


                ReceiptLine = new ReceiptLineType[]
                    {
                    new ReceiptLineType
                    {
                        ID= "1",
                        ReceivedQuantity = new QuantityType
                        {
                            unitCode = "KG",
                            Value = 150M
                        },
                        Item = new ItemType[]
                        {
                            new ItemType
                            {
                                Name = "IME PROIZVODA",
                                BuyersItemIdentification = new ItemIdentificationType
                                {
                                    ID = "4456985"
                                },
                                 AdditionalItemIdentification = new[] { new ItemIdentificationType
                                {
                                    ID=attAdditionalItemId("BARKOD"),
                                } },
                            }
                        }
                    },
                    new ReceiptLineType
            {
                ID = "2",
                ReceivedQuantity = new QuantityType
                        {
                            unitCode = "kom",
                            Value = 10M
                        },
                Item = new ItemType[]
               {
                            new ItemType
                            {
                                Name = "IME PROIZVODA",
                                BuyersItemIdentification = new ItemIdentificationType
                                {
                                    ID = "4456922"
                                },
                                 AdditionalItemIdentification = new[] { new ItemIdentificationType
                                {
                                    ID=attAdditionalItemId("BARKOD"),
                                } },
                            }
               }
                    

            },
            
}


};

return rec;
        }

        private static DespatchAdviceType OtpremnicaSrbija()
        {
            // custom attributes
            Func<decimal, AmountType> attAmountType = v => new AmountType { Value = v, currencyID = "RSD" };
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID = "9" };
            Func<string, IdentifierType> attAdditionalItemId = v => new IdentifierType { Value = v, schemeID = "GTIN" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };
            Func<string, CodeType> attDeliveryIdCode = v => new CodeType { Value = v, listAgencyID = "6", listAgencyName = "United Nations Economic Commission for Europe", listID = "ISO3166-1", listName = "Country", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listVersionID = "0.3", name = "String" };
            Func<string, IdentifierType> attTransportHandlingUnitID = v => new IdentifierType { Value = v, schemeID = "SSCC", schemeAgencyID = "9" };


            DespatchAdviceType des = new DespatchAdviceType
            {
                UBLVersionID = "2.1",
                ID = "OT111222",
                IssueDate = new DateTime(2020, 4, 25),
                IssueTime = "12:00:00",
                OrderReference = new[] { new OrderReferenceType
                {
                    ID = "NR562/2222",
                    IssueDate = new DateTime(2020, 4, 25)
                }
                },
                DespatchSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN DOBAVLJAČA"),
                        PartyName = new[] { new PartyNameType { Name = "Dobavljač d.o.o." } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica dobavljača",
                            BuildingNumber = "1",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Ulica dobavljača 1, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[] { new PartyLegalEntityType
                        {
                            RegistrationName = "Dobavljač d.o.o.",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },
                DeliveryCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("GLN DOSTAVNOG MESTA"),
                        PartyName = new[] { new PartyNameType { Name = "Naziv dostavnog mesta" } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica dostavnog mesta",
                            BuildingNumber = "3",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Adresa mesta dostave 3, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[] { new PartyLegalEntityType
                        {
                            RegistrationName = "Naziv dostavnog mesta",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN KUPCA"),
                        PartyName = new[] { new PartyNameType { Name = "Kupac d.o.o." } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica kupca",
                            BuildingNumber = "2",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Ulica kupca 2, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[] { new PartyLegalEntityType
                        {
                            RegistrationName = "Kupac d.o.o.",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },
                Shipment = new ShipmentType
                {
                    ID = "OT111222",
                    Delivery = new DeliveryType
                    {
                        ActualDeliveryDate = new DateTime(2020, 4, 25),
                        DeliveryLocation = new LocationType
                        {
                            Address = new AddressType
                            {
                                AddressLine = new[] { new AddressLineType { Line = "Adresa mesta dostave 3, 11000 Beograd, Republika Srbija" } },
                                Country = new CountryType { IdentificationCode = attDeliveryIdCode("RS"), Name = "Republika Srbija" }
                            }
                        }
                    }
                },

                DespatchLine = new[]
                    {
                    new DespatchLineType
                    {
                        ID= "1",
                        DeliveredQuantity = new QuantityType
                        {
                            unitCode = "KG",
                            Value = 150M
                        },
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "1",
                                OrderReference = new OrderReferenceType
                                {
                                    ID = "NR562/2222"
                                }
                            }
                        },

                            Item = new ItemType
                            {
                                Name = "IME PROIZVODA",
                                SellersItemIdentification = new ItemIdentificationType
                                {
                                    ID="289600",
                                },
                                AdditionalItemIdentification = new[] { new ItemIdentificationType
                                {
                                    ID=attAdditionalItemId("BARKOD"),
                                } },


                                ItemInstance = new ItemInstanceType[]
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType
                                    {
                                        LotNumberID = "546378239",
                                        ExpiryDate = "2021-08-28"
                                    }
                                }
                            }

                            },
                            Shipment = new ShipmentType[]
                {
                    new ShipmentType
                    {
                        ID = "1",
                        TransportHandlingUnit = new TransportHandlingUnitType[]
                        {
                            new TransportHandlingUnitType
                            {
                            ID = attTransportHandlingUnitID("173111000000000013")
                            }
                        }
                        },
                }},
                    new DespatchLineType
                    {
                        ID= "2",
                        DeliveredQuantity = new QuantityType
                        {
                            unitCode = "kom",
                            Value = 15M
                        },
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "2",
                                OrderReference = new OrderReferenceType
                                {
                                    ID = "NR562/2222"
                                }
                            }
                        },

                            Item = new ItemType
                            {
                                Name = "IME PROIZVODA",
                                SellersItemIdentification = new ItemIdentificationType
                                {
                                    ID="289601",
                                },
                                AdditionalItemIdentification = new[] { new ItemIdentificationType
                                {
                                    ID=attAdditionalItemId("BARKOD"),
                                } },


                                ItemInstance = new ItemInstanceType[]
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType
                                    {
                                        LotNumberID = "546378239",
                                        ExpiryDate = "2021-08-28"
                                    }
                                }
                            }
                            }
                            ,
                            Shipment = new ShipmentType[]
                {
                    new ShipmentType
                    {
                        ID = "2",
                        TransportHandlingUnit = new TransportHandlingUnitType[]
                        {
                            new TransportHandlingUnitType
                            {
                            ID = attTransportHandlingUnitID("173111000000000013")
                            }
                        }
                        },
                        },
                },
                    }


            };

            return des;
        }


        private static OrderType NarudzbenicaSrbija()
        {
            var data = GetData();
            // custom attributes
            Func<decimal, AmountType> attAmountType = v => new AmountType { Value = v, currencyID = "RSD" };
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID = "9" };
            Func<string, IdentifierType> attAdditionalItemId = v => new IdentifierType { Value = v, schemeID = "GTIN" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };


            OrderType ord = new OrderType
            {

                ID = "NR562/2222",
                IssueDate = new DateTime(2020, 4, 25),
                IssueTime = "09:38:47",
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN KUPCA"),
                        PartyName = new[] { new PartyNameType { Name = "Kupac d.o.o." } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica kupca",
                            BuildingNumber = "2",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Ulica kupca 2, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[]{ new PartyLegalEntityType
                        {
                            RegistrationName = "Kupac d.o.o.",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = attEndpoint("KROVNI GLN DOBAVLJAČA"),
                        PartyName = new[] { new PartyNameType { Name = "Dobavljač d.o.o." } },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Ulica dobavljača",
                            BuildingNumber = "1",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Ulica dobavljača 1, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        PartyLegalEntity = new[]{ new PartyLegalEntityType
                        {
                            RegistrationName = "Dobavljač d.o.o.",
                            CompanyID = "PIB"
                        },
                        }
                    }
                },
                Delivery = new[]
                    {
                    new DeliveryType
                    {
                        ActualDeliveryDate = new DateTime(2020,4,25),
                        DeliveryParty = new PartyType
                        {
                            EndpointID= attEndpoint("GLN DOSTAVNOG MESTA"),
                            PartyName = new[] { new PartyNameType { Name = "Naziv dostavnog mesta" } },
                            PostalAddress = new AddressType
                        {
                            StreetName = "Ulica dostavnog mesta",
                            BuildingNumber = "3",
                            CityName = "Beograd",
                            PostalZone = "11000",
                            AddressLine = new[] { new AddressLineType { Line = "Adresa mesta dostave 3, 11000 Beograd, Republika Srbija" } },
                            Country = new CountryType { IdentificationCode = attIdentificationCode("RS"), Name = "Republika Srbija" }
                        },
                        },
                    }
                },
                OrderLine = new[]
                    {
                    new OrderLineType
                    {
                        LineItem= new LineItemType
                        {
                            ID ="1",
                            Quantity = new QuantityType
                        {
                            unitCode = "KG",
                            Value = 150M
                        },
                            LineExtensionAmount =attAmountType(561.91M),
                            Price = new PriceType
                            {
                             PriceAmount=   attAmountType(37.46M),
                             BaseQuantity = new QuantityType
                        {
                            unitCode = "KG",
                            Value = 150M
                        },
                            },
                            Item = new ItemType
                            {
                                Name = "IME PROIZVODA",
                                BuyersItemIdentification = new ItemIdentificationType
                                {
                                    ID="4456985",
                                },
                                AdditionalItemIdentification = new[] { new ItemIdentificationType
                                {
                                    ID=attAdditionalItemId("BARKOD"),
                                },
                                }
                            }
                        },
                    },
                    new OrderLineType
                    {
                        LineItem= new LineItemType
                        {
                            ID ="2",
                            Quantity = new QuantityType
                        {
                            unitCode = "kom",
                            Value = 15M
                        },
                            LineExtensionAmount =attAmountType(852.51M),
                            Price = new PriceType
                            {
                             PriceAmount=   attAmountType(71.05M),
                             BaseQuantity = new QuantityType
                        {
                            unitCode = "kom",
                            Value = 15M
                        },
                            },
                            Item = new ItemType
                            {
                                Name = "IME PROIZVODA",
                                BuyersItemIdentification = new ItemIdentificationType
                                {
                                    ID="4456922",
                                },
                                AdditionalItemIdentification = new[] { new ItemIdentificationType
                                {
                                    ID=attAdditionalItemId("BARKOD"),
                                },
                                }
                            }
                        },
                    }
                },
                


            };

            return ord;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string xmlFilename = @"C:\Temp\NarudzbenicaSrbija.xml";
            OrderType invoice = NarudzbenicaSrbija();

            XmlWriterSettings setting = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = false
            };

            using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting))
            {
                new XmlSerializer(invoice.GetType()).Serialize(writer, invoice);
            }

            // Make sure namespace declarations are on a separate line. Easy reading
            var utf16AttributedWithUtf8 = File.ReadAllText(xmlFilename);
            utf16AttributedWithUtf8 = utf16AttributedWithUtf8.Replace("xmlns", Environment.NewLine + "\t\txmlns");
            File.WriteAllText(xmlFilename, utf16AttributedWithUtf8, Encoding.UTF8);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string xmlFilename = @"C:\Temp\OtpremnicaSrbija.xml";
            DespatchAdviceType despatch = OtpremnicaSrbija();

            XmlWriterSettings setting = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = false
            };

            using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting))
            {
                new XmlSerializer(despatch.GetType()).Serialize(writer, despatch);
            }

            // Make sure namespace declarations are on a separate line. Easy reading
            var utf16AttributedWithUtf8 = File.ReadAllText(xmlFilename);
            utf16AttributedWithUtf8 = utf16AttributedWithUtf8.Replace("xmlns", Environment.NewLine + "\t\txmlns");
            File.WriteAllText(xmlFilename, utf16AttributedWithUtf8, Encoding.UTF8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string xmlFilename = @"C:\Temp\PotvrdaPrijemaSrbija.xml";
            ReceiptAdviceType ack = PotvrdaPrijemaSrbija();

            XmlWriterSettings setting = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = false
            };

            using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting))
            {
                new XmlSerializer(ack.GetType()).Serialize(writer, ack);
            }

            // Make sure namespace declarations are on a separate line. Easy reading
            var utf16AttributedWithUtf8 = File.ReadAllText(xmlFilename);
            utf16AttributedWithUtf8 = utf16AttributedWithUtf8.Replace("xmlns", Environment.NewLine + "\t\txmlns");
            File.WriteAllText(xmlFilename, utf16AttributedWithUtf8, Encoding.UTF8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xmlFilename = @"C:\Temp\PotvrdaPrijemaNarudzbeniceSrbija.xml";
            OrderResponseSimpleType ackOrd = PotvrdaPrijemaNarudzbeniceSrbija();

            XmlWriterSettings setting = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = false
            };

            using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting))
            {
                new XmlSerializer(ackOrd.GetType()).Serialize(writer, ackOrd);
            }

            // Make sure namespace declarations are on a separate line. Easy reading
            var utf16AttributedWithUtf8 = File.ReadAllText(xmlFilename);
            utf16AttributedWithUtf8 = utf16AttributedWithUtf8.Replace("xmlns", Environment.NewLine + "\t\txmlns");
            File.WriteAllText(xmlFilename, utf16AttributedWithUtf8, Encoding.UTF8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string xmlFilename = @"C:\Temp\StanjeZalihaSrbija.xml";
            StockAvailabilityReportType supply = StanjeZalihaSrbija();

            XmlWriterSettings setting = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = false
            };

            using (XmlWriter writer = XmlWriter.Create(xmlFilename, setting))
            {
                new XmlSerializer(supply.GetType()).Serialize(writer, supply);
            }

            // Make sure namespace declarations are on a separate line. Easy reading
            var utf16AttributedWithUtf8 = File.ReadAllText(xmlFilename);
            utf16AttributedWithUtf8 = utf16AttributedWithUtf8.Replace("xmlns", Environment.NewLine + "\t\txmlns");
            File.WriteAllText(xmlFilename, utf16AttributedWithUtf8, Encoding.UTF8);
        }
    }
}
