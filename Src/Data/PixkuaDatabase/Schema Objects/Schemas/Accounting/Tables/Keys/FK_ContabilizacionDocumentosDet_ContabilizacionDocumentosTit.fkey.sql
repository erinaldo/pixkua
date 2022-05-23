/****** Object:  ForeignKey [FK_ContabilizacionDocumentosDet_ContabilizacionDocumentosTit]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[ContabilizacionDocumentosDet]  WITH CHECK ADD  CONSTRAINT [FK_ContabilizacionDocumentosDet_ContabilizacionDocumentosTit] FOREIGN KEY([IdContabilizacionDocumentoTit])
REFERENCES [Accounting].[ContabilizacionDocumentosTit] ([IdContabilizacionDocumentoTit])


GO
ALTER TABLE [Accounting].[ContabilizacionDocumentosDet] CHECK CONSTRAINT [FK_ContabilizacionDocumentosDet_ContabilizacionDocumentosTit]

