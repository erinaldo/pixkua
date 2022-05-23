/****** Object:  ForeignKey [FK_PoliticasPropiedades_PropiedadesControles]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[PoliticasPropiedades]  WITH NOCHECK ADD  CONSTRAINT [FK_PoliticasPropiedades_PropiedadesControles] FOREIGN KEY([IdPropiedadControl])
REFERENCES [dbo].[PropiedadesControles] ([IdPropiedadControl])


GO
ALTER TABLE [dbo].[PoliticasPropiedades] CHECK CONSTRAINT [FK_PoliticasPropiedades_PropiedadesControles]

