/****** Object:  ForeignKey [FK_CentrosRecepcionAccesos_CentrosRecepcion]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CentrosRecepcionAccesos]  WITH CHECK ADD  CONSTRAINT [FK_CentrosRecepcionAccesos_CentrosRecepcion] FOREIGN KEY([IdCentroRecepcion])
REFERENCES [Purchasing].[CentrosRecepcion] ([IdCentroRecepcion])


GO
ALTER TABLE [Purchasing].[CentrosRecepcionAccesos] CHECK CONSTRAINT [FK_CentrosRecepcionAccesos_CentrosRecepcion]

