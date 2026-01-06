namespace Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TRLEI.Integration.BizTalk.PatronInfoEnquiryRequest",@"PatronInfoEnquiryRequest")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PatronInfoEnquiryRequest"})]
    public sealed class PatronInfoEnquiryRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TRLEI.Integration.BizTalk.PatronInfoEnquiryRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://TRLEI.Integration.BizTalk.PatronInfoEnquiryRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PatronInfoEnquiryRequest"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ToSystem"" type=""xs:string"" />
        <xs:element name=""MessageID"" type=""xs:string"" />
        <xs:element name=""FromSystem"" type=""xs:string"" />
        <xs:element name=""PatronID"" type=""xs:string"" />
        <xs:element name=""IncludeStopCodes"" type=""xs:boolean"" />
        <xs:element name=""IncludeProfile"" type=""xs:boolean"" />
        <xs:element name=""IncludePhone"" type=""xs:boolean"" />
        <xs:element name=""IncludeIndentification"" type=""xs:boolean"" />
        <xs:element name=""IncludeEmail"" type=""xs:boolean"" />
        <xs:element name=""IncludeClub"" type=""xs:boolean"" />
        <xs:element name=""IncludeAddress"" type=""xs:boolean"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PatronInfoEnquiryRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PatronInfoEnquiryRequest";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
