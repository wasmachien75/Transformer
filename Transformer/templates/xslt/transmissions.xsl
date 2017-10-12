<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" encoding="UTF-8" indent="yes"/>
	
	<xsl:template match="/">
	    <transmissions>
		<xsl:for-each select="transmissions/ES_TRANSMISSION">
		    <tx starttime="{tx_starttime/ESP_TIMEDURATION/@time}" product="{tx_product/ES_PRODUCT/@p_product_title}" runnumber="{@tx_runnumberwithincontract}"/>
		</xsl:for-each>
	    </transmissions>
	</xsl:template>
	
</xsl:stylesheet>
