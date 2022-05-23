/****** Object:  ForeignKey [FK_ListasPreciosArticulos_ListasPrecios]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ListasPreciosArticulos]  WITH CHECK ADD  CONSTRAINT [FK_ListasPreciosArticulos_ListasPrecios] FOREIGN KEY([IdListaPrecio])
REFERENCES [Sales].[ListasPrecios] ([IdListaPrecio])


GO
ALTER TABLE [Sales].[ListasPreciosArticulos] CHECK CONSTRAINT [FK_ListasPreciosArticulos_ListasPrecios]

