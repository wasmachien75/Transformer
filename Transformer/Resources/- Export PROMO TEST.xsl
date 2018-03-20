<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" encoding="UTF-8" indent="yes" cdata-section-elements="ESP_TEXT"/>


<xsl:template match="/">
	<RTBF_Move_Export_file>	
	<xsl:choose>
		<xsl:when test="trailercampaigns">
		      
			<Informations_Generales>
				<FullDate_Generation_File>
				      <xsl:value-of select="trailercampaigns/exportinformation/timestamp/ESP_TIMEINSTANT/@full"/>
				</FullDate_Generation_File>
				<Auteur>
				      <xsl:value-of select="trailercampaigns/exportinformation/@username"/>
				</Auteur>
			
			</Informations_Generales>
			
			<xsl:call-template name="generateID">
			        <xsl:with-param name="zzz" select="trailercampaigns/ES_TRAILERCAMPAIGN/tc_trailers/ES_PRODUCT"/>
			</xsl:call-template>
		</xsl:when>
		
		
		<xsl:when test="trailers">
		      
			<Informations_Generales>
				<FullDate_Generation_File>
				      <xsl:value-of select="trailers/exportinformation/timestamp/ESP_TIMEINSTANT/@full"/>
				</FullDate_Generation_File>
				<Auteur>
				      <xsl:value-of select="trailers/exportinformation/@username"/>
				</Auteur>
				      
			</Informations_Generales>
				<xsl:call-template name="generateID">
				      <xsl:with-param name="zzz" select="trailers/ES_PRODUCT"/>
				</xsl:call-template>
			
		</xsl:when>
				
		<xsl:when test="programs"> 		
		      
		      
		      <Informations_Generales>
			      <FullDate_Generation_File>
				      <xsl:value-of select="programs/exportinformation/timestamp/ESP_TIMEINSTANT/@full"/>
			      </FullDate_Generation_File>
			      <Auteur>
				      <xsl:value-of select="programs/exportinformation/@username"/>
			      </Auteur>
			      
			</Informations_Generales>      
				      
			      <xsl:call-template name="generateID">
				      <xsl:with-param name="zzz" select="programs/ES_PRODUCT"/>
			      </xsl:call-template>
		</xsl:when>
	</xsl:choose>
	</RTBF_Move_Export_file>
</xsl:template>	
	


	
<xsl:template name="generateID">
<xsl:param name="zzz"/>

	<Exports>
				
		<xsl:for-each select="$zzz">
			<Export>
				
				<xsl:for-each select="p_product_mediasets/ES_MEDIASET[@ms_isvisible = 'true' and  ms_visioninginformation/ES_VISIONINGINFORMATION/vi_digitalvisioningstatus/ESP_VISIONINGSTATUS/@usercode = 'S+Ve+Vu+' and  ms_registrations/ES_REGISTRATION/rg_digitalcarrier/ES_CARRIER/@car_label != '']">
				<xsl:sort select="p_product_mediasets/cutLists/ES_WONCUTLIST/@cl_id"  order="descending"/>	
					
					<xsl:choose>
						
						<xsl:when test=" cutLists/ES_WONCUTLIST/@cl_id != '' and position()= 1 ">
							
								
								<Media_ID>
									<xsl:value-of select="ms_registrations/ES_REGISTRATION/rg_digitalcarrier/ES_CARRIER/@car_label"/>
								</Media_ID>
												
								<xsl:for-each select="ms_registrations/ES_REGISTRATION[position()= 1]/rg_digitalcarrier/ES_CARRIER/fileParts/ES_DIGITALCARRIERFILEPART">
									
									<File_ID>
										<xsl:value-of select="@fileID"/>
									</File_ID>
															
								</xsl:for-each>
							
								<Cut_List>
									<xsl:value-of select="cutLists/ES_WONCUTLIST/@cl_id"/>
								</Cut_List>
								
							
						</xsl:when>
							
						
					</xsl:choose>

				</xsl:for-each>
				
					
				<Product_Full_Title>
					<xsl:choose>
						<xsl:when test="@p_episode_broadcastseriestitle and (@p_episode_broadcastseriestitle != @p_product_broadcasttitle)">
							<xsl:value-of select="concat(translate(@p_episode_broadcastseriestitle, './ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüýÿ' ,'--AAAAAACEEEEIIIINOOOOOUUUUYaaaaaaceeeeiiiinooooouuuuyy'),' : ', translate(@p_product_broadcasttitle, ' ./ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüýÿ' ,'_--AAAAAACEEEEIIIINOOOOOUUUUYaaaaaaceeeeiiiinooooouuuuyy'))"/>
						</xsl:when>
					
						<xsl:when test="@p_product_title">
							<xsl:value-of select="translate(@p_product_title, './ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüýÿ' ,'--AAAAAACEEEEIIIINOOOOOUUUUYaaaaaaceeeeiiiinooooouuuuyy')"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="translate(@p_product_broadcasttitle, './ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüýÿ' ,'--AAAAAACEEEEIIIINOOOOOUUUUYaaaaaaceeeeiiiinooooouuuuyy')"/>
						</xsl:otherwise>
					</xsl:choose>
				</Product_Full_Title>

				<Serie_Title>
					<xsl:value-of select="translate(@p_episode_broadcastseriestitle, './ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüýÿ' ,'--AAAAAACEEEEIIIINOOOOOUUUUYaaaaaaceeeeiiiinooooouuuuyy')"/>
				</Serie_Title>
				
				<Episode_Title>
					<xsl:value-of select="translate(@p_product_broadcasttitle, './ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝàáâãäåçèéêëìíîïñòóôõöùúûüýÿ' ,'--AAAAAACEEEEIIIINOOOOOUUUUYaaaaaaceeeeiiiinooooouuuuyy')"/>
				</Episode_Title>
				
				<Duration>
					<xsl:apply-templates select="p_product_duration/ESP_TIMEDURATION" mode="WithFrames"/>
				</Duration>
				
				<Won_id>
					<xsl:value-of select="@p_product_productcode"/>
				</Won_id>
								
				<Image_Format>
					<xsl:value-of  select="p_product_mediasets/ES_MEDIASET/ms_technicalvisioning/ES_TECHNICALVISIONING/tv_imageratio/ESP_IMAGEFORMAT/@name"/>
				</Image_Format>
				
				<Subtitling_Sets>
					<xsl:value-of  select="p_product_mediasets/ES_MEDIASET/ms_subtitlingsets/ES_MEDIASET/@carrierLabel"/>
				</Subtitling_Sets>
				
								
			</Export>
		</xsl:for-each>
	</Exports>
	
</xsl:template>




<xsl:template match="ESP_TIMEDURATION" mode="WithFrames">
	<xsl:value-of select="concat(format-number(@hours,'00'),':',format-number(@minutes,'00'),':',format-number(@seconds,'00'),'.',format-number(@frames,'00'))"/>
</xsl:template>
</xsl:stylesheet>