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
    /// <para>DictionaryEntryName: Reminder. Details</para>
    /// <para>Definition: A document used to remind a customer of payments past due.</para>
    /// <para>ObjectClass: Reminder</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Reminder", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Reminder-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("Reminder", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Reminder-2", IsNullable=false)]
#endif
    public partial class ReminderType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// <para>AlternativeBusinessTerms: Invoice Date</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Reminder Type Code. Code</para>
        /// <para>Definition: A code signifying the type of the Reminder.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Reminder Type Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ReminderTypeCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Reminder Sequence. Numeric</para>
        /// <para>Definition: The number of the current Reminder in the sequence of reminders relating to the specified payments; the number of reminders previously sent plus one.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Reminder Sequence</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType ReminderSequenceNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Tax Point Date. Date</para>
        /// <para>Definition: The date of the Reminder, used to indicate the point at which tax becomes applicable.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Tax Point Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType TaxPointDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Document_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the default currency for this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
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
        /// <para>DictionaryEntryName: Reminder. Tax_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency used for tax amounts in the Reminder.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
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
        /// <para>DictionaryEntryName: Reminder. Pricing_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency used for prices in the Reminder.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
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
        /// <para>DictionaryEntryName: Reminder. Payment_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency used for payment in the Reminder.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Payment</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PaymentCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Payment Alternative_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the alternative currency used for payment in the Reminder.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Payment Alternative</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PaymentAlternativeCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Accounting Cost Code. Code</para>
        /// <para>Definition: The buyer's accounting code, applied to the Reminder as a whole.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Accounting Cost Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AccountingCostCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Accounting Cost. Text</para>
        /// <para>Definition: The buyer's accounting code, applied to the Reminder as a whole, expressed as text.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Accounting Cost</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AccountingCost { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Reminder. Line Count. Numeric</para>
        /// <para>Definition: The number of Reminder Lines in this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Reminder_ Period. Period</para>
        /// <para>Definition: The periods to which the Reminder applies.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Reminder</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReminderPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] ReminderPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Accounting_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The accounting supplier party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Accounting_ Customer Party. Customer Party</para>
        /// <para>Definition: The accounting customer party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Payee_ Party. Party</para>
        /// <para>Definition: The payee.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Payee</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Tax Representative_ Party. Party</para>
        /// <para>Definition: The tax representative.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Tax Representative</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Payment Means</para>
        /// <para>Definition: Expected means of payment.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Payment Means</para>
        /// <para>AssociatedObjectClass: Payment Means</para>
        /// <para>RepresentationTerm: Payment Means</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Payment Terms</para>
        /// <para>Definition: A set of payment terms associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Payment Terms</para>
        /// <para>AssociatedObjectClass: Payment Terms</para>
        /// <para>RepresentationTerm: Payment Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Prepaid_ Payment. Payment</para>
        /// <para>Definition: A prepaid payment.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Prepaid</para>
        /// <para>PropertyTerm: Payment</para>
        /// <para>AssociatedObjectClass: Payment</para>
        /// <para>RepresentationTerm: Payment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PrepaidPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentType[] PrepaidPayment { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Allowance Charge</para>
        /// <para>Definition: A discount or charge that applies to a price component.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Allowance Charge</para>
        /// <para>AssociatedObjectClass: Allowance Charge</para>
        /// <para>RepresentationTerm: Allowance Charge</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Tax_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the tax currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Tax</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Pricing_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the pricing currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Pricing</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Payment_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the payment currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Payment</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Payment Alternative_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the payment alternative currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Payment Alternative</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Tax Total</para>
        /// <para>Definition: The total amount of a specific type of tax.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Tax Total</para>
        /// <para>AssociatedObjectClass: Tax Total</para>
        /// <para>RepresentationTerm: Tax Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Legal_ Monetary Total. Monetary Total</para>
        /// <para>Definition: The total amount payable on the Invoice, including Allowances, Charges, and Taxes.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTermQualifier: Legal</para>
        /// <para>PropertyTerm: Monetary Total</para>
        /// <para>AssociatedObjectClass: Monetary Total</para>
        /// <para>RepresentationTerm: Monetary Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Reminder. Reminder Line</para>
        /// <para>Definition: A line describing a payment past due.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Reminder</para>
        /// <para>PropertyTerm: Reminder Line</para>
        /// <para>AssociatedObjectClass: Reminder Line</para>
        /// <para>RepresentationTerm: Reminder Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReminderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ReminderLineType[] ReminderLine { get; set; }
    }
}
