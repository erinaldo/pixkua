/****** Object:  ForeignKey [FK_UnidadesNegocio_Regiones]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[UnidadesNegocio]  WITH NOCHECK ADD  CONSTRAINT [FK_UnidadesNegocio_Regiones] FOREIGN KEY([IdRegion])
REFERENCES [Sales].[Regiones] ([IdRegion])


GO
ALTER TABLE [Sales].[UnidadesNegocio] NOCHECK CONSTRAINT [FK_UnidadesNegocio_Regiones]

