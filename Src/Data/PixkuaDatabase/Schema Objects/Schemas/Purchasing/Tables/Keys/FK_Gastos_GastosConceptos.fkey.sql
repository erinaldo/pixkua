/****** Object:  ForeignKey [FK_Gastos_GastosConceptos]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Gastos]  WITH CHECK ADD  CONSTRAINT [FK_Gastos_GastosConceptos] FOREIGN KEY([IdGastoConcepto])
REFERENCES [Purchasing].[GastosConceptos] ([IdGastoConcepto])


GO
ALTER TABLE [Purchasing].[Gastos] CHECK CONSTRAINT [FK_Gastos_GastosConceptos]

