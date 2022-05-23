/****** Object:  ForeignKey [FK_PresupuestosCategorias_CategoriasPresupuestales]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[PresupuestosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_PresupuestosCategorias_CategoriasPresupuestales] FOREIGN KEY([IdCategoriaPresupuestal])
REFERENCES [Purchasing].[CategoriasPresupuestales] ([IdCategoriaPresupuestal])


GO
ALTER TABLE [Purchasing].[PresupuestosCategorias] CHECK CONSTRAINT [FK_PresupuestosCategorias_CategoriasPresupuestales]

