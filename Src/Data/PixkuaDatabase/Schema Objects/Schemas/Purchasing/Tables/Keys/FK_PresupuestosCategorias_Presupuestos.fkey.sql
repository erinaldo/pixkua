/****** Object:  ForeignKey [FK_PresupuestosCategorias_Presupuestos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[PresupuestosCategorias]  WITH CHECK ADD  CONSTRAINT [FK_PresupuestosCategorias_Presupuestos] FOREIGN KEY([IdPresupuesto])
REFERENCES [Purchasing].[Presupuestos] ([IdPresupuesto])


GO
ALTER TABLE [Purchasing].[PresupuestosCategorias] CHECK CONSTRAINT [FK_PresupuestosCategorias_Presupuestos]

