/****** Object:  ForeignKey [FK_CategoriasPresupuestalesArticulos_CategoriasPresupuestales]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CategoriasPresupuestalesArticulos]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasPresupuestalesArticulos_CategoriasPresupuestales] FOREIGN KEY([IdCategoriaPresupuestal])
REFERENCES [Purchasing].[CategoriasPresupuestales] ([IdCategoriaPresupuestal])


GO
ALTER TABLE [Purchasing].[CategoriasPresupuestalesArticulos] CHECK CONSTRAINT [FK_CategoriasPresupuestalesArticulos_CategoriasPresupuestales]

