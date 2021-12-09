// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     https://github.com/Gammern/ubllarsen
//     
// </auto-generated>
//------------------------------------------------------------------------------
namespace exYuUBLGenerator
{
    using Cac;
    using Udt;
    
    
    /// <summary>
    /// ComponentType: ABIE
    /// <para>DictionaryEntryName: Catalogue Pricing Update. Details</para>
    /// <para>Definition: A document used to update information about prices in an existing Catalogue.</para>
    /// <para>ObjectClass: Catalogue Pricing Update</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("CataloguePricingUpdate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("CataloguePricingUpdate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2", IsNullable=false)]
#endif
    public partial class CataloguePricingUpdateType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Name</para>
        /// <para>Definition: Text, assigned by the sender, that identifies this document to business users.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Name</para>
        /// <para>RepresentationTerm: Name</para>
        /// <para>DataType: Name. Type</para>
        /// <para>Examples: Seasonal Promotion</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType Name { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Revision Date. Date</para>
        /// <para>Definition: The date, assigned by the seller, on which the Catalogue was revised.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Revision Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType RevisionDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Revision Time. Time</para>
        /// <para>Definition: The time, assigned by the seller, at which the Catalogue was revised.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Revision Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType RevisionTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Description. Text</para>
        /// <para>Definition: Describes the Catalogue Revision.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Description</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// <para>Examples: adjustment of prices for Christmas trading period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Version. Identifier</para>
        /// <para>Definition: Indicates the current version of the catalogue.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Version</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 1.1</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Line Count. Numeric</para>
        /// <para>Definition: The number of lines in the document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Validity_ Period. Period</para>
        /// <para>Definition: A period, assigned by the seller, during which the information in the Catalogue Revision is effective. This may be given as start and end dates or as a duration.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Validity</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] ValidityPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Related_ Catalogue Reference. Catalogue Reference</para>
        /// <para>Definition: A reference to the Catalogue being updated.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Related</para>
        /// <para>PropertyTerm: Catalogue Reference</para>
        /// <para>AssociatedObjectClass: Catalogue Reference</para>
        /// <para>RepresentationTerm: Catalogue Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CatalogueReferenceType RelatedCatalogueReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Referenced_ Contract. Contract</para>
        /// <para>Definition: A contract or framework agreement with which the Catalogue is associated.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Referenced</para>
        /// <para>PropertyTerm: Contract</para>
        /// <para>AssociatedObjectClass: Contract</para>
        /// <para>RepresentationTerm: Contract</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractType[] ReferencedContract { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Provider_ Party. Party</para>
        /// <para>Definition: The party sending the Catalogue Pricing Update.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Provider</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ProviderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Receiver_ Party. Party</para>
        /// <para>Definition: The party receiving the Catalogue Pricing Update.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Receiver</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Seller_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Seller</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Contractor_ Customer Party. Customer Party</para>
        /// <para>Definition: The customer party responsible for the contracts with which the Catalogue is associated.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Contractor</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType ContractorCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Trading Terms</para>
        /// <para>Definition: The trading terms associated with the Catalogue.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Trading Terms</para>
        /// <para>AssociatedObjectClass: Trading Terms</para>
        /// <para>RepresentationTerm: Trading Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TradingTermsType TradingTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Default_ Language. Language</para>
        /// <para>Definition: The default language for the catalogue pricing update.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTermQualifier: Default</para>
        /// <para>PropertyTerm: Language</para>
        /// <para>AssociatedObjectClass: Language</para>
        /// <para>RepresentationTerm: Language</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LanguageType DefaultLanguage { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Catalogue Pricing Update. Catalogue Pricing Update Line</para>
        /// <para>Definition: One or more lines in the Catalogue Pricing Update, each line updating a specific catalogue item.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Catalogue Pricing Update</para>
        /// <para>PropertyTerm: Catalogue Pricing Update Line</para>
        /// <para>AssociatedObjectClass: Catalogue Pricing Update Line</para>
        /// <para>RepresentationTerm: Catalogue Pricing Update Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CataloguePricingUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CataloguePricingUpdateLineType[] CataloguePricingUpdateLine { get; set; }
    }
}
