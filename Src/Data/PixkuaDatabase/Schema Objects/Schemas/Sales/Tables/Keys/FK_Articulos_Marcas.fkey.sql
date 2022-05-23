/****** Object:  ForeignKey [FK_Articulos_Marcas]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Marcas] FOREIGN KEY([IdMarca])
REFERENCES [Sales].[Marcas] ([IdMarca])


GO
ALTER TABLE [Sales].[Articulos] CHECK CONSTRAINT [FK_Articulos_Marcas]

