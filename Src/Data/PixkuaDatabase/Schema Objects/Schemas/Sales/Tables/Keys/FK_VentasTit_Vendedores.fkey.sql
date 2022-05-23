/****** Object:  ForeignKey [FK_VentasTit_Vendedores]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasTit]  WITH NOCHECK ADD  CONSTRAINT [FK_VentasTit_Vendedores] FOREIGN KEY([IdVendedor])
REFERENCES [Sales].[Vendedores] ([IdVendedor])
NOT FOR REPLICATION


GO
ALTER TABLE [Sales].[VentasTit] NOCHECK CONSTRAINT [FK_VentasTit_Vendedores]

