/****** Object:  Check [CK_ClientesDomicilios_Tipo]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ClientesDomicilios]  WITH CHECK ADD  CONSTRAINT [CK_ClientesDomicilios_Tipo] CHECK  (([TipoDomicilio]='F' OR [TipoDomicilio]='E'))


GO
ALTER TABLE [Sales].[ClientesDomicilios] CHECK CONSTRAINT [CK_ClientesDomicilios_Tipo]

