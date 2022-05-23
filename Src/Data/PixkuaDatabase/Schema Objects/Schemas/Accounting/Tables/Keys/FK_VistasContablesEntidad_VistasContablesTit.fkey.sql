/****** Object:  ForeignKey [FK_VistasContablesEntidad_VistasContablesTit]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesEntidad]  WITH CHECK ADD  CONSTRAINT [FK_VistasContablesEntidad_VistasContablesTit] FOREIGN KEY([IdVistaContableTit])
REFERENCES [Accounting].[VistasContablesTit] ([IdVistaContableTit])


GO
ALTER TABLE [Accounting].[VistasContablesEntidad] CHECK CONSTRAINT [FK_VistasContablesEntidad_VistasContablesTit]

