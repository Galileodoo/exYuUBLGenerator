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
namespace exYuUBLGenerator.Xades
{
    using DS;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertificateValuesType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(AnyType))]
        public object[] Items { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class EncapsulatedPKIDataType
    {
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Encoding { get; set; }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value { get; set; }
        
#if USE_IMPLICIT_ASSIGNMENT
        public static implicit operator EncapsulatedPKIDataType(System.Byte[] value)
        {
             return new EncapsulatedPKIDataType { Value = value };
        }

        public static implicit operator System.Byte[](EncapsulatedPKIDataType @this)
        {
             return @this.Value;
        }
#endif
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class AnyType
    {
        
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any { get; set; }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class RevocationValuesType
    {
        
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
        public EncapsulatedPKIDataType[] CRLValues { get; set; }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
        public EncapsulatedPKIDataType[] OCSPValues { get; set; }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable=false)]
        public AnyType[] OtherValues { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("ArchiveTimeStampV2", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable=false)]
#endif
    public partial class XAdESTimeStampType : GenericTimeStampType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public abstract partial class GenericTimeStampType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
        public object[] Items { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public CanonicalizationMethodType CanonicalizationMethod { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
        public object[] Items1 { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IncludeType
    {
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool referencedData { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referencedDataSpecified { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ReferenceInfoType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethodType DigestMethod { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
        public byte[] DigestValue { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OtherTimeStampType : GenericTimeStampType
    {
    }
}
