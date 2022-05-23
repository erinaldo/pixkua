/****** Object:  ForeignKey [FK_Presupuestos_Periodos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Presupuestos]  WITH CHECK ADD  CONSTRAINT [FK_Presupuestos_Periodos] FOREIGN KEY([IdPeriodo])
REFERENCES [Purchasing].[Periodos] ([IdPeriodo])


GO
ALTER TABLE [Purchasing].[Presupuestos] CHECK CONSTRAINT [FK_Presupuestos_Periodos]

