/****** Object:  ForeignKey [FK_MovimientosTit_Almacenes]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[MovimientosTit]  WITH CHECK ADD  CONSTRAINT [FK_MovimientosTit_Almacenes] FOREIGN KEY([IdAlmacen])
REFERENCES [Inventory].[Almacenes] ([IdAlmacen])


GO
ALTER TABLE [Inventory].[MovimientosTit] CHECK CONSTRAINT [FK_MovimientosTit_Almacenes]

