/****** Object:  ForeignKey [FK_ContabilizacionDocumentosTit_VistasContablesTit]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[ContabilizacionDocumentosTit]  WITH CHECK ADD  CONSTRAINT [FK_ContabilizacionDocumentosTit_VistasContablesTit] FOREIGN KEY([IdVistaContableTit])
REFERENCES [Accounting].[VistasContablesTit] ([IdVistaContableTit])


GO
ALTER TABLE [Accounting].[ContabilizacionDocumentosTit] CHECK CONSTRAINT [FK_ContabilizacionDocumentosTit_VistasContablesTit]

