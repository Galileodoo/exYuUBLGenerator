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
    /// <para>DictionaryEntryName: Product Activity. Details</para>
    /// <para>Definition: A document reporting the movement of goods at specified retail locations for inventory tracking purposes.</para>
    /// <para>ObjectClass: Product Activity</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("ProductActivity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ProductActivity-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("ProductActivity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ProductActivity-2", IsNullable=false)]
#endif
    public partial class ProductActivityType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Product Activity. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Product Activity. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Product Activity. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// <para>AlternativeBusinessTerms: Activity Date</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Product Activity. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Product Activity. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Product Activity. Document_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the default currency for this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTermQualifier: Document</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Product Activity. Activity_ Period. Period</para>
        /// <para>Definition: The period covered by this Product Activity report.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTermQualifier: Activity</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType ActivityPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Product Activity. Document Reference</para>
        /// <para>Definition: A reference to another document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Product Activity. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Product Activity. Sender_ Party. Party</para>
        /// <para>Definition: The sender of the Product Activity.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTermQualifier: Sender</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType SenderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Product Activity. Receiver_ Party. Party</para>
        /// <para>Definition: The receiver of the Product Activity.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTermQualifier: Receiver</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Product Activity. Supply Chain_ Activity Data Line. Activity Data Line</para>
        /// <para>Definition: A line describing the movement of goods to a specific location.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Product Activity</para>
        /// <para>PropertyTermQualifier: Supply Chain</para>
        /// <para>PropertyTerm: Activity Data Line</para>
        /// <para>AssociatedObjectClass: Activity Data Line</para>
        /// <para>RepresentationTerm: Activity Data Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SupplyChainActivityDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ActivityDataLineType[] SupplyChainActivityDataLine { get; set; }
    }
}