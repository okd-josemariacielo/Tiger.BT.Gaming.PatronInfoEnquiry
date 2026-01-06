namespace Tiger.BT.Gaming.PlayerInfoEnquiry.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse", typeof(global::Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse", typeof(global::Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse))]
    public sealed class PatronInfoEnquiryHAloResToFCMSRes : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:s0=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:ns0=""http://TRLEI.Integration.BizTalk.PatronInfoEnquiryResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:s2sMessage"" />
  </xsl:template>
  <xsl:template match=""/s1:s2sMessage"">
    <ns0:PatronInfoEnquiryResponse>
      <playerInfoList>
        <ns0:playerId>
          <xsl:value-of select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/@s0:playerId"" />
        </ns0:playerId>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerProfile"">
          <playerProfile>
            <xsl:if test=""@s0:title"">
              <ns0:title>
                <xsl:value-of select=""@s0:title"" />
              </ns0:title>
            </xsl:if>
            <xsl:if test=""@s0:suffix"">
              <ns0:suffix>
                <xsl:value-of select=""@s0:suffix"" />
              </ns0:suffix>
            </xsl:if>
            <xsl:if test=""@s0:registeredProperty"">
              <ns0:registeredProperty>
                <xsl:value-of select=""@s0:registeredProperty"" />
              </ns0:registeredProperty>
            </xsl:if>
            <xsl:if test=""@s0:registeredDateTime"">
              <ns0:registeredDateTime>
                <xsl:value-of select=""@s0:registeredDateTime"" />
              </ns0:registeredDateTime>
            </xsl:if>
            <xsl:if test=""@s0:preferredName"">
              <ns0:preferredName>
                <xsl:value-of select=""@s0:preferredName"" />
              </ns0:preferredName>
            </xsl:if>
            <xsl:if test=""@s0:playerWeight"">
              <ns0:playerWeight>
                <xsl:value-of select=""@s0:playerWeight"" />
              </ns0:playerWeight>
            </xsl:if>
            <xsl:if test=""@s0:playerVIP"">
              <ns0:playerVIP>
                <xsl:value-of select=""@s0:playerVIP"" />
              </ns0:playerVIP>
            </xsl:if>
            <ns0:playerProperty>
              <xsl:value-of select=""@s0:playerProperty"" />
            </ns0:playerProperty>
            <xsl:if test=""@s0:playerHeight"">
              <ns0:playerHeight>
                <xsl:value-of select=""@s0:playerHeight"" />
              </ns0:playerHeight>
            </xsl:if>
            <xsl:if test=""@s0:playerActive"">
              <ns0:playerActive>
                <xsl:value-of select=""@s0:playerActive"" />
              </ns0:playerActive>
            </xsl:if>
            <xsl:if test=""@s0:pinNumber"">
              <ns0:pinNumber>
                <xsl:value-of select=""@s0:pinNumber"" />
              </ns0:pinNumber>
            </xsl:if>
            <xsl:if test=""@s0:pinActive"">
              <ns0:pinActive>
                <xsl:value-of select=""@s0:pinActive"" />
              </ns0:pinActive>
            </xsl:if>
            <ns0:lastName1>
              <xsl:value-of select=""@s0:lastName1"" />
            </ns0:lastName1>
            <xsl:if test=""@s0:middleName"">
              <ns0:middleName>
                <xsl:value-of select=""@s0:middleName"" />
              </ns0:middleName>
            </xsl:if>
            <xsl:if test=""@s0:hairColor"">
              <ns0:hairColor>
                <xsl:value-of select=""@s0:hairColor"" />
              </ns0:hairColor>
            </xsl:if>
            <xsl:if test=""@s0:genderType"">
              <ns0:genderType>
                <xsl:value-of select=""@s0:genderType"" />
              </ns0:genderType>
            </xsl:if>
            <xsl:if test=""@s0:fullName"">
              <ns0:fullName>
                <xsl:value-of select=""@s0:fullName"" />
              </ns0:fullName>
            </xsl:if>
            <ns0:firstName>
              <xsl:value-of select=""@s0:firstName"" />
            </ns0:firstName>
            <xsl:if test=""@s0:eyeColor"">
              <ns0:eyeColor>
                <xsl:value-of select=""@s0:eyeColor"" />
              </ns0:eyeColor>
            </xsl:if>
            <xsl:if test=""@s0:ctrComplete"">
              <ns0:ctrComplete>
                <xsl:value-of select=""@s0:ctrComplete"" />
              </ns0:ctrComplete>
            </xsl:if>
            <ns0:birthDate>
              <xsl:value-of select=""@s0:birthDate"" />
            </ns0:birthDate>
            <xsl:value-of select=""./text()"" />
          </playerProfile>
        </xsl:for-each>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerAddress"">
          <playerAddress>
            <xsl:if test=""@s0:stateProvCode"">
              <ns0:stateProvCode>
                <xsl:value-of select=""@s0:stateProvCode"" />
              </ns0:stateProvCode>
            </xsl:if>
            <xsl:if test=""@s0:returnedMail"">
              <ns0:returnedMail>
                <xsl:value-of select=""@s0:returnedMail"" />
              </ns0:returnedMail>
            </xsl:if>
            <xsl:if test=""@s0:primaryAddress"">
              <ns0:primaryAddress>
                <xsl:value-of select=""@s0:primaryAddress"" />
              </ns0:primaryAddress>
            </xsl:if>
            <xsl:if test=""@s0:postCode"">
              <ns0:postCode>
                <xsl:value-of select=""@s0:postCode"" />
              </ns0:postCode>
            </xsl:if>
            <xsl:if test=""@s0:mailtoAddress"">
              <ns0:mailtoAddress>
                <xsl:value-of select=""@s0:mailtoAddress"" />
              </ns0:mailtoAddress>
            </xsl:if>
            <xsl:if test=""@s0:excludeAddress"">
              <ns0:excludeAddress>
                <xsl:value-of select=""@s0:excludeAddress"" />
              </ns0:excludeAddress>
            </xsl:if>
            <xsl:if test=""@s0:countryCode"">
              <ns0:countryCode>
                <xsl:value-of select=""@s0:countryCode"" />
              </ns0:countryCode>
            </xsl:if>
            <ns0:addressType>
              <xsl:value-of select=""@s0:addressType"" />
            </ns0:addressType>
            <xsl:if test=""@s0:addressLine3"">
              <ns0:addressLine3>
                <xsl:value-of select=""@s0:addressLine3"" />
              </ns0:addressLine3>
            </xsl:if>
            <xsl:if test=""@s0:addressLine2"">
              <ns0:addressLine2>
                <xsl:value-of select=""@s0:addressLine2"" />
              </ns0:addressLine2>
            </xsl:if>
            <xsl:if test=""@s0:addressLine1"">
              <ns0:addressLine1>
                <xsl:value-of select=""@s0:addressLine1"" />
              </ns0:addressLine1>
            </xsl:if>
            <ns0:addressId>
              <xsl:value-of select=""@s0:addressId"" />
            </ns0:addressId>
            <xsl:if test=""@s0:addressCity"">
              <ns0:addressCity>
                <xsl:value-of select=""@s0:addressCity"" />
              </ns0:addressCity>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </playerAddress>
        </xsl:for-each>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerPhone"">
          <playerPhone>
            <xsl:if test=""@s0:primaryPhone"">
              <ns0:primaryPhone>
                <xsl:value-of select=""@s0:primaryPhone"" />
              </ns0:primaryPhone>
            </xsl:if>
            <ns0:phoneType>
              <xsl:value-of select=""@s0:phoneType"" />
            </ns0:phoneType>
            <ns0:phoneNumber>
              <xsl:value-of select=""@s0:phoneNumber"" />
            </ns0:phoneNumber>
            <ns0:phoneId>
              <xsl:value-of select=""@s0:phoneId"" />
            </ns0:phoneId>
            <xsl:if test=""@s0:phoneCountry"">
              <ns0:phoneCountry>
                <xsl:value-of select=""@s0:phoneCountry"" />
              </ns0:phoneCountry>
            </xsl:if>
            <xsl:if test=""@s0:phoneAreaCode"">
              <ns0:phoneAreaCode>
                <xsl:value-of select=""@s0:phoneAreaCode"" />
              </ns0:phoneAreaCode>
            </xsl:if>
            <xsl:if test=""@s0:excludePhone"">
              <ns0:excludePhone>
                <xsl:value-of select=""@s0:excludePhone"" />
              </ns0:excludePhone>
            </xsl:if>
            <xsl:if test=""@s0:calltoPhone"">
              <ns0:calltoPhone>
                <xsl:value-of select=""@s0:calltoPhone"" />
              </ns0:calltoPhone>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </playerPhone>
        </xsl:for-each>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerEmail"">
          <playerEmail>
            <xsl:if test=""@s0:excludeEmail"">
              <ns0:excludeEmail>
                <xsl:value-of select=""@s0:excludeEmail"" />
              </ns0:excludeEmail>
            </xsl:if>
            <ns0:emailId>
              <xsl:value-of select=""@s0:emailId"" />
            </ns0:emailId>
            <xsl:if test=""@s0:emailAddress"">
              <ns0:emailAddress>
                <xsl:value-of select=""@s0:emailAddress"" />
              </ns0:emailAddress>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </playerEmail>
        </xsl:for-each>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerIdent"">
          <playerIdent>
            <xsl:if test=""@s0:verifiedDateTime"">
              <ns0:verifiedDateTime>
                <xsl:value-of select=""@s0:verifiedDateTime"" />
              </ns0:verifiedDateTime>
            </xsl:if>
            <xsl:if test=""@s0:stateProvCode"">
              <ns0:stateProvCode>
                <xsl:value-of select=""@s0:stateProvCode"" />
              </ns0:stateProvCode>
            </xsl:if>
            <ns0:identType>
              <xsl:value-of select=""@s0:identType"" />
            </ns0:identType>
            <xsl:if test=""@s0:identNumber"">
              <ns0:identNumber>
                <xsl:value-of select=""@s0:identNumber"" />
              </ns0:identNumber>
            </xsl:if>
            <ns0:identId>
              <xsl:value-of select=""@s0:identId"" />
            </ns0:identId>
            <xsl:if test=""@s0:identExpiry"">
              <ns0:identExpiry>
                <xsl:value-of select=""@s0:identExpiry"" />
              </ns0:identExpiry>
            </xsl:if>
            <xsl:if test=""@s0:identVerified"">
              <ns0:identVerified>
                <xsl:value-of select=""@s0:identVerified"" />
              </ns0:identVerified>
            </xsl:if>
            <xsl:if test=""@s0:identActive"">
              <ns0:identActive>
                <xsl:value-of select=""@s0:identActive"" />
              </ns0:identActive>
            </xsl:if>
            <xsl:if test=""@s0:countryCode"">
              <ns0:countryCode>
                <xsl:value-of select=""@s0:countryCode"" />
              </ns0:countryCode>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </playerIdent>
        </xsl:for-each>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerStop"">
          <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDate()"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;true&quot;)"" />
          <playerStop>
            <ns0:stopType>
              <xsl:value-of select=""@s0:stopType"" />
            </ns0:stopType>
            <ns0:stopEffectiveDate>
              <xsl:value-of select=""$var:v1"" />
            </ns0:stopEffectiveDate>
            <ns0:stopActive>
              <xsl:value-of select=""$var:v2"" />
            </ns0:stopActive>
            <xsl:value-of select=""./text()"" />
          </playerStop>
        </xsl:for-each>
        <xsl:for-each select=""s1:s2sBody/s0:playerInfo/s0:playerInfoList/s0:playerClub"">
          <playerClub>
            <xsl:if test=""@s0:playerClubExpDate"">
              <ns0:playerClubExpDate>
                <xsl:value-of select=""@s0:playerClubExpDate"" />
              </ns0:playerClubExpDate>
            </xsl:if>
            <xsl:if test=""@s0:playerClubEffDate"">
              <ns0:playerClubEffDate>
                <xsl:value-of select=""@s0:playerClubEffDate"" />
              </ns0:playerClubEffDate>
            </xsl:if>
            <xsl:if test=""@s0:playerClubActive"">
              <ns0:playerClubActive>
                <xsl:value-of select=""@s0:playerClubActive"" />
              </ns0:playerClubActive>
            </xsl:if>
            <xsl:if test=""@s0:clubNotify"">
              <ns0:clubNotify>
                <xsl:value-of select=""@s0:clubNotify"" />
              </ns0:clubNotify>
            </xsl:if>
            <xsl:if test=""@s0:clubName"">
              <ns0:clubName>
                <xsl:value-of select=""@s0:clubName"" />
              </ns0:clubName>
            </xsl:if>
            <ns0:clubId>
              <xsl:value-of select=""@s0:clubId"" />
            </ns0:clubId>
            <xsl:if test=""@s0:cardSuffix"">
              <ns0:cardSuffix>
                <xsl:value-of select=""@s0:cardSuffix"" />
              </ns0:cardSuffix>
            </xsl:if>
            <xsl:value-of select=""./text()"" />
          </playerClub>
        </xsl:for-each>
      </playerInfoList>
    </ns0:PatronInfoEnquiryResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse";
        
        private const global::Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse";
        
        private const global::Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Tiger.BT.Gaming.PlayerEnquiry.Schemas.HAlo.BallyGetPlayerInfoResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Tiger.BT.Gaming.PlayerInfoEnquiry.Schemas.FCMS.PatronInfoEnquiryResponse";
                return _TrgSchemas;
            }
        }
    }
}
