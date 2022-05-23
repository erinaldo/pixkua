/****** Object:  ForeignKey [FK_ClasificacionesArticulos_ArticulosStock]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ClasificacionesArticulos]  WITH CHECK ADD  CONSTRAINT [FK_ClasificacionesArticulos_ArticulosStock] FOREIGN KEY([IdArticuloStock])
REFERENCES [Inventory].[ArticulosStock] ([IdArticuloStock])


GO
ALTER TABLE [Inventory].[ClasificacionesArticulos] CHECK CONSTRAINT [FK_ClasificacionesArticulos_ArticulosStock]

