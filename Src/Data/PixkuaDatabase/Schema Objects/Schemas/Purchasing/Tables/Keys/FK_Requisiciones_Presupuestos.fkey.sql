/****** Object:  ForeignKey [FK_Requisiciones_Presupuestos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Requisiciones]  WITH NOCHECK ADD  CONSTRAINT [FK_Requisiciones_Presupuestos] FOREIGN KEY([IdPresupuesto])
REFERENCES [Purchasing].[Presupuestos] ([IdPresupuesto])
NOT FOR REPLICATION


GO
ALTER TABLE [Purchasing].[Requisiciones] NOCHECK CONSTRAINT [FK_Requisiciones_Presupuestos]

