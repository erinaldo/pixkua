/****** Object:  ForeignKey [FK_ContabilizacionDocumentosTit_Tipos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[ContabilizacionDocumentosTit]  WITH CHECK ADD  CONSTRAINT [FK_ContabilizacionDocumentosTit_Tipos] FOREIGN KEY([IdDocumentoTipo])
REFERENCES [Documents].[Tipos] ([IdDocumentoTipo])


GO
ALTER TABLE [Accounting].[ContabilizacionDocumentosTit] CHECK CONSTRAINT [FK_ContabilizacionDocumentosTit_Tipos]

