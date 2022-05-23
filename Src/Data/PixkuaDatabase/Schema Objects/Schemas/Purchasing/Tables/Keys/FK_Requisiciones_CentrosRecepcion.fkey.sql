/****** Object:  ForeignKey [FK_Requisiciones_CentrosRecepcion]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Requisiciones]  WITH CHECK ADD  CONSTRAINT [FK_Requisiciones_CentrosRecepcion] FOREIGN KEY([IdCentroRecepcion])
REFERENCES [Purchasing].[CentrosRecepcion] ([IdCentroRecepcion])


GO
ALTER TABLE [Purchasing].[Requisiciones] CHECK CONSTRAINT [FK_Requisiciones_CentrosRecepcion]

