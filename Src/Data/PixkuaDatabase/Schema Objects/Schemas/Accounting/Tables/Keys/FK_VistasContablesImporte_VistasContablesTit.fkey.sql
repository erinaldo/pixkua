/****** Object:  ForeignKey [FK_VistasContablesImporte_VistasContablesTit]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesImporte]  WITH CHECK ADD  CONSTRAINT [FK_VistasContablesImporte_VistasContablesTit] FOREIGN KEY([IdVistaContableTit])
REFERENCES [Accounting].[VistasContablesTit] ([IdVistaContableTit])


GO
ALTER TABLE [Accounting].[VistasContablesImporte] CHECK CONSTRAINT [FK_VistasContablesImporte_VistasContablesTit]

