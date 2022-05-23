/****** Object:  ForeignKey [FK_VistasContablesImporte_Importes]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesImporte]  WITH CHECK ADD  CONSTRAINT [FK_VistasContablesImporte_Importes] FOREIGN KEY([IdImporte])
REFERENCES [Accounting].[Importes] ([IdImporte])


GO
ALTER TABLE [Accounting].[VistasContablesImporte] CHECK CONSTRAINT [FK_VistasContablesImporte_Importes]

