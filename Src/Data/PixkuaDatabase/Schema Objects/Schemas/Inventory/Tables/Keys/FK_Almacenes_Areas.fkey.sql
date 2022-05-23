/****** Object:  ForeignKey [FK_Almacenes_Areas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Almacenes]  WITH CHECK ADD  CONSTRAINT [FK_Almacenes_Areas] FOREIGN KEY([IdArea])
REFERENCES [Inventory].[Areas] ([IdArea])


GO
ALTER TABLE [Inventory].[Almacenes] CHECK CONSTRAINT [FK_Almacenes_Areas]

