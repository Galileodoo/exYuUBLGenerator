using exYuUBLGenerator;
using exYuUBLGenerator.Cac;
using exYuUBLGenerator.Udt;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace GUIGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static DespatchAdviceType OtpremnicaSrbija()
        {
            // custom attributes
            Func<decimal, AmountType> attAmountType = v => new AmountType { Value = v, currencyID = "RSD" };
            Func<decimal, QuantityType> attQuantity = v => new QuantityType { Value = v, unitCode = "H87" };
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID = "9" };
            Func<string, IdentifierType> attAdditionalItemId = v => new IdentifierType { Value = v, schemeID = "GTIN" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };
            Func<string, CodeType> attDeliveryIdCode = v => new CodeType { Value = v, listAgencyID = "6", listAgencyName = "United Nations Economic Commission for Europe" ,listID = "ISO3166-1" ,listName = "Country" ,listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listVersionID = "0.3", name = "String" };
            Func<string, IdentifierType> attTransportHandlingUnitID = v => new IdentifierType { Value = v, schemeID = "SSCC", schemeAgencyID = "9" };


            DespatchAdviceType res = new DespatchAdviceType
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
                        DeliveredQuantity = attQuantity(15M),
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
                        DeliveredQuantity = attQuantity(12M),
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

            return res;
        }

        private static OrderType NarudzbenicaSrbija()
        {
            // custom attributes
            Func<decimal, AmountType> attAmountType = v => new AmountType { Value = v, currencyID = "RSD" };
            Func<decimal, QuantityType> attQuantity = v => new QuantityType { Value = v, unitCode = "H87" };
            Func<string, IdentifierType> attEndpoint = v => new IdentifierType { Value = v, schemeID = "GLN", schemeAgencyID="9" };
            Func<string, IdentifierType> attAdditionalItemId = v => new IdentifierType { Value = v, schemeID = "GTIN" };
            Func<string, CodeType> attIdentificationCode = v => new CodeType { Value = v, listID = "ISO3166-1", listAgencyID = "6", listName = "Country", listVersionID = "0.3", listURI = "http://docs.oasis-open.org/ubl/os-ubl-2.0/cl/gc/default/CountryIdentificationCode-2.0.gc", listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0" };
          

        OrderType res = new OrderType
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
                            Country = new CountryType { IdentificationCode= attIdentificationCode("RS"), Name = "Republika Srbija" }
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
                        EndpointID= attEndpoint("KROVNI GLN DOBAVLJAČA"),
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
                            Quantity = attQuantity(15),
                            LineExtensionAmount =attAmountType(561.91M),
                            Price = new PriceType
                            {
                             PriceAmount=   attAmountType(37.46M),
                             BaseQuantity= attQuantity(15),
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
                            Quantity = attQuantity(12),
                            LineExtensionAmount =attAmountType(852.51M),
                            Price = new PriceType
                            {
                             PriceAmount=   attAmountType(71.05M),
                             BaseQuantity= attQuantity(12),
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

            return res;
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
    }
}