/****** Object:  ForeignKey [FK_CFDSeries_CFDCertificados]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CFDSeries]  WITH CHECK ADD  CONSTRAINT [FK_CFDSeries_CFDCertificados] FOREIGN KEY([IdCFDCertificado])
REFERENCES [Accounting].[CFDCertificados] ([IdCFDCertificado])


GO
ALTER TABLE [Accounting].[CFDSeries] CHECK CONSTRAINT [FK_CFDSeries_CFDCertificados]

