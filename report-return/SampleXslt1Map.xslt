<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0 userCSharp" version="1.0" xmlns:ns0="http://BizTalk_Server_Project4.StringFunctoidsDestinationSchema" xmlns:s0="http://BizTalk_Server_Project4.StringFunctoidsSourceSchema" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:import href="http://btsfunctoids.blob.core.windows.net/functoids/functoids.xslt" />
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:Root" />
  </xsl:template>
  <xsl:template match="/s0:Root">
    <xsl:variable name="var:v1" select="userCSharp:StringFind(string(StringFindSource/text()) , &quot;SearchString&quot;)" />
    <xsl:variable name="var:v2" select="userCSharp:StringLeft(string(StringLeftSource/text()) , &quot;2&quot;)" />
    <xsl:variable name="var:v3" select="userCSharp:StringRight(string(StringRightSource/text()) , &quot;2&quot;)" />
    <xsl:variable name="var:v4" select="userCSharp:StringUpperCase(string(UppercaseSource/text()))" />
    <xsl:variable name="var:v5" select="userCSharp:StringLowerCase(string(LowercaseSource/text()))" />
    <xsl:variable name="var:v6" select="userCSharp:StringSize(string(SizeSource/text()))" />
    <xsl:variable name="var:v7" select="userCSharp:StringSubstring(string(StringExtractSource/text()) , &quot;0&quot; , &quot;2&quot;)" />
    <xsl:variable name="var:v8" select="userCSharp:StringConcat(string(StringConcatSource/text()))" />
    <xsl:variable name="var:v9" select="userCSharp:StringTrimLeft(string(StringLeftTrimSource/text()))" />
    <xsl:variable name="var:v10" select="userCSharp:StringTrimRight(string(StringRightTrimSource/text()))" />
    <ns0:Root>
      <StringFindDestination>
        <xsl:value-of select="$var:v1" />
      </StringFindDestination>
      <StringLeftDestination>
        <xsl:value-of select="$var:v2" />
      </StringLeftDestination>
      <StringRightDestination>
        <xsl:value-of select="$var:v3" />
      </StringRightDestination>
      <UppercaseDestination>
        <xsl:value-of select="$var:v4" />
      </UppercaseDestination>
      <LowercaseDestination>
        <xsl:value-of select="$var:v5" />
      </LowercaseDestination>
      <SizeDestination>
        <xsl:value-of select="$var:v6" />
      </SizeDestination>
      <StringExtractDestination>
        <xsl:value-of select="$var:v7" />
      </StringExtractDestination>
      <StringConcatDestination>
        <xsl:value-of select="$var:v8" />
      </StringConcatDestination>
      <StringLeftTrimDestination>
        <xsl:value-of select="$var:v9" />
      </StringLeftTrimDestination>
      <StringRightTrimDestination>
        <xsl:value-of select="$var:v10" />
      </StringRightTrimDestination>
          <StringRightTrimDestination>
        <xsl:value-of select="$var:v11" />
      </StringRightTrimDestination>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>