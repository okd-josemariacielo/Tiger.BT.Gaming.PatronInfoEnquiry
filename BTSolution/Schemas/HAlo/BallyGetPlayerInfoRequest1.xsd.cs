namespace Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli",@"playerInfo")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"playerInfo"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest", typeof(global::Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest))]
    public sealed class BallyGetPlayerInfoRequest1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:s2s=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:pli=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" elementFormDefault=""qualified"" targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoRequest"" namespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" />
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""playerInfo"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""getPlayerInfo"">
          <xs:complexType>
            <xs:attribute form=""qualified"" name=""playerId"" type=""xs:string"" use=""required"" />
            <xs:attribute form=""qualified"" name=""includeStops"" type=""xs:boolean"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""includeProfile"" type=""xs:boolean"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""includePhones"" type=""xs:boolean"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""includeIdents"" type=""xs:boolean"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""includeEmails"" type=""xs:boolean"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""includeClubs"" type=""xs:boolean"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""includeAddresses"" type=""xs:boolean"" use=""optional"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute ref=""s2s:transAction"" />
      <xs:attribute ref=""s2s:transStation"" />
      <xs:attribute ref=""s2s:transEmployee"" />
      <xs:attribute ref=""s2s:transDateTime"" use=""required"" />
      <xs:attribute ref=""s2s:transApproved"" />
      <xs:attribute ref=""s2s:timeToLive"" />
      <xs:attribute ref=""s2s:sessionType"" use=""required"" />
      <xs:attribute ref=""s2s:sessionRetry"" />
      <xs:attribute ref=""s2s:sessionId"" />
      <xs:attribute ref=""s2s:retryCount"" />
      <xs:attribute ref=""s2s:propertyId"" use=""required"" />
      <xs:attribute ref=""s2s:gameDate"" use=""required"" />
      <xs:attribute ref=""s2s:dateTime"" use=""required"" />
      <xs:attribute ref=""s2s:commandId"" />
      <xs:attribute ref=""s2s:clientType"" />
      <xs:attribute ref=""s2s:clientId"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BallyGetPlayerInfoRequest1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "playerInfo";
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
