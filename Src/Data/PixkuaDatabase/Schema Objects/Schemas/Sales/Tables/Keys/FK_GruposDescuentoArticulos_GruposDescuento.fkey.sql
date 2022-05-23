/****** Object:  ForeignKey [FK_GruposDescuentoArticulos_GruposDescuento]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[GruposDescuentoArticulos]  WITH CHECK ADD  CONSTRAINT [FK_GruposDescuentoArticulos_GruposDescuento] FOREIGN KEY([IdGrupoDescuento])
REFERENCES [Sales].[GruposDescuento] ([IdGrupoDescuento])


GO
ALTER TABLE [Sales].[GruposDescuentoArticulos] CHECK CONSTRAINT [FK_GruposDescuentoArticulos_GruposDescuento]

