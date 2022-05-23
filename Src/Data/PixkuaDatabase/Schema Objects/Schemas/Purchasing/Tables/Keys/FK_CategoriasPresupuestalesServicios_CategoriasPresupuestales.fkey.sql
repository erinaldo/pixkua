/****** Object:  ForeignKey [FK_CategoriasPresupuestalesServicios_CategoriasPresupuestales]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CategoriasPresupuestalesServicios]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasPresupuestalesServicios_CategoriasPresupuestales] FOREIGN KEY([IdCategoriaPresupuestal])
REFERENCES [Purchasing].[CategoriasPresupuestales] ([IdCategoriaPresupuestal])


GO
ALTER TABLE [Purchasing].[CategoriasPresupuestalesServicios] CHECK CONSTRAINT [FK_CategoriasPresupuestalesServicios_CategoriasPresupuestales]

