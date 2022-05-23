/****** Object:  ForeignKey [FK_PoliticasPropiedades_Politicas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[PoliticasPropiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_PoliticasPropiedades_Politicas] FOREIGN KEY([IdPolitica])
REFERENCES [dbo].[Politicas] ([IdPolitica])
ON DELETE CASCADE


GO
ALTER TABLE [dbo].[PoliticasPropiedades] CHECK CONSTRAINT [FK_PoliticasPropiedades_Politicas]

