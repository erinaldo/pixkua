/****** Object:  ForeignKey [FK_DepartamentosCentrosRecepcion_CentrosRecepcion]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCentrosRecepcion]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentosCentrosRecepcion_CentrosRecepcion] FOREIGN KEY([IdCentroRecepcion])
REFERENCES [Purchasing].[CentrosRecepcion] ([IdCentroRecepcion])


GO
ALTER TABLE [Purchasing].[DepartamentosCentrosRecepcion] CHECK CONSTRAINT [FK_DepartamentosCentrosRecepcion_CentrosRecepcion]

