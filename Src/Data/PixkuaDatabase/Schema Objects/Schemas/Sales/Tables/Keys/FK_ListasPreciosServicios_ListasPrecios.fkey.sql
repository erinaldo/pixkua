/****** Object:  ForeignKey [FK_ListasPreciosServicios_ListasPrecios]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ListasPreciosServicios]  WITH CHECK ADD  CONSTRAINT [FK_ListasPreciosServicios_ListasPrecios] FOREIGN KEY([IdListaPrecio])
REFERENCES [Sales].[ListasPrecios] ([IdListaPrecio])


GO
ALTER TABLE [Sales].[ListasPreciosServicios] CHECK CONSTRAINT [FK_ListasPreciosServicios_ListasPrecios]

