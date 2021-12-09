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
    /// <para>DictionaryEntryName: Order Response. Details</para>
    /// <para>Definition: A document used to indicate detailed acceptance or rejection of an Order or to make a counter-offer.</para>
    /// <para>ObjectClass: Order Response</para>
    /// <para>AlternativeBusinessTerms: Order Acknowledgement, PO Response</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("OrderResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderResponse-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("OrderResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderResponse-2", IsNullable=false)]
#endif
    public partial class OrderResponseType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Sales_ Order Identifier. Identifier</para>
        /// <para>Definition: An identifier for the Order, issued by the Seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Sales</para>
        /// <para>PropertyTerm: Order Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SalesOrderID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Order Response Code. Code</para>
        /// <para>Definition: A code signifying the type of response for this Order.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Order Response Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType OrderResponseCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Document_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the default currency for this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Document</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Pricing_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency that is used for all prices in the Order Response.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Pricing</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PricingCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Tax_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency that is used for all tax amounts in the Order Response.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Tax</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TaxCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Total_ Packages Quantity. Quantity</para>
        /// <para>Definition: The total number of packages contained in the Order Response.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Total</para>
        /// <para>PropertyTerm: Packages Quantity</para>
        /// <para>RepresentationTerm: Quantity</para>
        /// <para>DataType: Quantity. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType TotalPackagesQuantity { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Gross_ Weight. Measure</para>
        /// <para>Definition: The total gross weight for the Order Response (goods + packaging + transport equipment).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Gross</para>
        /// <para>PropertyTerm: Weight</para>
        /// <para>RepresentationTerm: Measure</para>
        /// <para>DataType: Measure. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossWeightMeasure { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Net_ Weight. Measure</para>
        /// <para>Definition: The total net weight for the Order Response (goods + packaging).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Net</para>
        /// <para>PropertyTerm: Weight</para>
        /// <para>RepresentationTerm: Measure</para>
        /// <para>DataType: Measure. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetWeightMeasure { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Net Net_ Weight. Measure</para>
        /// <para>Definition: The total net weight of the goods in the Order Response excluding packaging.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Net Net</para>
        /// <para>PropertyTerm: Weight</para>
        /// <para>RepresentationTerm: Measure</para>
        /// <para>DataType: Measure. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetNetWeightMeasure { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Gross_ Volume. Measure</para>
        /// <para>Definition: The total volume of the goods in the Order Response including packaging.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Gross</para>
        /// <para>PropertyTerm: Volume</para>
        /// <para>RepresentationTerm: Measure</para>
        /// <para>DataType: Measure. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType GrossVolumeMeasure { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Net_ Volume. Measure</para>
        /// <para>Definition: The total volume of the goods in the Order Response excluding packaging.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Net</para>
        /// <para>PropertyTerm: Volume</para>
        /// <para>RepresentationTerm: Measure</para>
        /// <para>DataType: Measure. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeasureType NetVolumeMeasure { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Customer_ Reference. Text</para>
        /// <para>Definition: A supplementary reference assigned by the buyer, e.g., the CRI in a purchasing card transaction.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Customer</para>
        /// <para>PropertyTerm: Reference</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType CustomerReference { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Accounting Cost Code. Code</para>
        /// <para>Definition: An accounting cost code applied to the order as a whole.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Accounting Cost Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AccountingCostCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Accounting Cost. Text</para>
        /// <para>Definition: An accounting cost code applied to the order as a whole, expressed as text.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Accounting Cost</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AccountingCost { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Order Response. Line Count. Numeric</para>
        /// <para>Definition: The number of Order Lines in this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Validity_ Period. Period</para>
        /// <para>Definition: The period for which the Order Response is valid.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Validity</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] ValidityPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Order Reference</para>
        /// <para>Definition: A reference to the Order being responded to.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Order Reference</para>
        /// <para>AssociatedObjectClass: Order Reference</para>
        /// <para>RepresentationTerm: Order Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType[] OrderReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Order_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an Order other than the one being responded to.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Order</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OrderDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Originator_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an originator document associated with this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Originator</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType OriginatorDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Contract</para>
        /// <para>Definition: A contract associated with the Order being responded to.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Contract</para>
        /// <para>AssociatedObjectClass: Contract</para>
        /// <para>RepresentationTerm: Contract</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractType[] Contract { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Seller_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The seller.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Seller</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Buyer_ Customer Party. Customer Party</para>
        /// <para>Definition: The buyer.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Buyer</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Originator_ Customer Party. Customer Party</para>
        /// <para>Definition: The originator.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Originator</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType OriginatorCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Freight Forwarder_ Party. Party</para>
        /// <para>Definition: A freight forwarder or carrier.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Freight Forwarder</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType FreightForwarderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Accounting_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The accounting supplier party.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Accounting_ Customer Party. Customer Party</para>
        /// <para>Definition: The accounting customer party.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Delivery</para>
        /// <para>Definition: A delivery associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Delivery</para>
        /// <para>AssociatedObjectClass: Delivery</para>
        /// <para>RepresentationTerm: Delivery</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryType[] Delivery { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Delivery Terms</para>
        /// <para>Definition: A set of delivery terms associated with this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Delivery Terms</para>
        /// <para>AssociatedObjectClass: Delivery Terms</para>
        /// <para>RepresentationTerm: Delivery Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryTermsType DeliveryTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Payment Means</para>
        /// <para>Definition: Expected means of payment.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Payment Means</para>
        /// <para>AssociatedObjectClass: Payment Means</para>
        /// <para>RepresentationTerm: Payment Means</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Payment Terms</para>
        /// <para>Definition: A set of payment terms associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Payment Terms</para>
        /// <para>AssociatedObjectClass: Payment Terms</para>
        /// <para>RepresentationTerm: Payment Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Allowance Charge</para>
        /// <para>Definition: A discount or charge that applies to a price component.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Allowance Charge</para>
        /// <para>AssociatedObjectClass: Allowance Charge</para>
        /// <para>RepresentationTerm: Allowance Charge</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Transaction Conditions</para>
        /// <para>Definition: A specification of purchasing or sales conditions applying to the whole Order.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Transaction Conditions</para>
        /// <para>AssociatedObjectClass: Transaction Conditions</para>
        /// <para>RepresentationTerm: Transaction Conditions</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TransactionConditionsType TransactionConditions { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Tax_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the tax currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Tax</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Pricing_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the pricing currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Pricing</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Payment_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the payment currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Payment</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Destination_ Country. Country</para>
        /// <para>Definition: The country of destination (for customs purposes).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Destination</para>
        /// <para>PropertyTerm: Country</para>
        /// <para>AssociatedObjectClass: Country</para>
        /// <para>RepresentationTerm: Country</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CountryType DestinationCountry { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Tax Total</para>
        /// <para>Definition: The total amount of a specific type of tax, as calculated by the seller.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Tax Total</para>
        /// <para>AssociatedObjectClass: Tax Total</para>
        /// <para>RepresentationTerm: Tax Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Legal_ Monetary Total. Monetary Total</para>
        /// <para>Definition: The total amount of the Order (or counter-offer).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTermQualifier: Legal</para>
        /// <para>PropertyTerm: Monetary Total</para>
        /// <para>AssociatedObjectClass: Monetary Total</para>
        /// <para>RepresentationTerm: Monetary Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Order Response. Order Line</para>
        /// <para>Definition: A line associated with a line in the Catalogue and specifying a kind of item being ordered.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Order Response</para>
        /// <para>PropertyTerm: Order Line</para>
        /// <para>AssociatedObjectClass: Order Line</para>
        /// <para>RepresentationTerm: Order Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderLineType[] OrderLine { get; set; }
    }
}
