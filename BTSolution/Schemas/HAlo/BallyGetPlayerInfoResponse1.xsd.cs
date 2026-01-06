namespace Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli",@"playerInfo")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"playerInfo"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse", typeof(global::Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse))]
    public sealed class BallyGetPlayerInfoResponse1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:s2s=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:pli=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" elementFormDefault=""qualified"" targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse"" namespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" />
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
        <xs:element name=""playerInfoList"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""playerProfile"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""title"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""suffix"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""registeredProperty"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""registeredDateTime"" type=""xs:dateTime"" />
                  <xs:attribute form=""qualified"" name=""preferredName"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""playerWeight"" type=""xs:long"" />
                  <xs:attribute form=""qualified"" name=""playerVIP"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""playerProperty"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""playerHeight"" type=""xs:long"" />
                  <xs:attribute form=""qualified"" name=""playerActive"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""pinNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""256"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""pinActive"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""lastName1"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""middleName"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""hairColor"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""genderType"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""fullName"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""firstName"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""eyeColor"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""ctrComplete"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""birthDate"" type=""xs:date"" use=""required"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""playerAddress"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""stateProvCode"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""returnedMail"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""primaryAddress"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""postCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""8"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""mailtoAddress"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""excludeAddress"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""countryCode"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""addressType"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""addressLine3"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""addressLine2"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""addressLine1"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""addressId"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""addressCity"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""playerPhone"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""primaryPhone"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""phoneType"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""phoneNumber"" use=""required"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""32"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""phoneId"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""phoneCountry"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""3"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""phoneAreaCode"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""6"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""excludePhone"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""calltoPhone"" type=""xs:boolean"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""playerEmail"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""excludeEmail"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""emailId"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""emailAddress"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""playerIdent"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""verifiedDateTime"" type=""xs:dateTime"" />
                  <xs:attribute form=""qualified"" name=""stateProvCode"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""identType"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""identNumber"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""32"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""identId"" use=""required"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""32"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""identExpiry"" type=""xs:dateTime"" />
                  <xs:attribute form=""qualified"" name=""identVerified"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""identActive"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""countryCode"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""playerStop"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""stopType"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""stopEffectiveDate"" type=""xs:date"" />
                  <xs:attribute form=""qualified"" name=""stopActive"" type=""xs:boolean"" />
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""playerClub"">
                <xs:complexType>
                  <xs:attribute form=""qualified"" name=""playerClubExpDate"" type=""xs:date"" />
                  <xs:attribute form=""qualified"" name=""playerClubEffDate"" type=""xs:date"" />
                  <xs:attribute form=""qualified"" name=""playerClubActive"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""clubNotify"" type=""xs:boolean"" />
                  <xs:attribute form=""qualified"" name=""clubName"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""clubId"" use=""required"">
                    <xs:simpleType>
                      <xs:restriction base=""xs:string"">
                        <xs:maxLength value=""32"" />
                      </xs:restriction>
                    </xs:simpleType>
                  </xs:attribute>
                  <xs:attribute form=""qualified"" name=""cardSuffix"" type=""xs:int"" use=""optional"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
            <xs:attribute form=""qualified"" name=""playerId"" type=""xs:string"" use=""required"" />
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
      <xs:attribute ref=""s2s:errorText"" />
      <xs:attribute ref=""s2s:errorCode"" />
      <xs:attribute ref=""s2s:dateTime"" use=""required"" />
      <xs:attribute ref=""s2s:commandId"" />
      <xs:attribute ref=""s2s:clientType"" />
      <xs:attribute ref=""s2s:clientId"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BallyGetPlayerInfoResponse1() {
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
