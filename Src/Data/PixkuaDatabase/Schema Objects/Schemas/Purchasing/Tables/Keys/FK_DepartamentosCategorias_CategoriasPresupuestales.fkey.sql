/****** Object:  ForeignKey [FK_DepartamentosCategorias_CategoriasPresupuestales]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_DepartamentosCategorias_CategoriasPresupuestales] FOREIGN KEY([IdCategoriaPresupuestal])
REFERENCES [Purchasing].[CategoriasPresupuestales] ([IdCategoriaPresupuestal])


GO
ALTER TABLE [Purchasing].[DepartamentosCategorias] CHECK CONSTRAINT [FK_DepartamentosCategorias_CategoriasPresupuestales]

