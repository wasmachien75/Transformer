<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" encoding="utf-8" indent="yes" />
  <xsl:template match="/">
    <txevents>
      <xsl:for-each select="txevents/ES_BMTXEVENT">
        <event starttime="{starttime/ESP_TIMEDURATION/@time}" endtime="{endtime/ESP_TIMEDURATION/@time}" title="{@title}"/>
      </xsl:for-each>
    </txevents>
  </xsl:template>
</xsl:stylesheet>