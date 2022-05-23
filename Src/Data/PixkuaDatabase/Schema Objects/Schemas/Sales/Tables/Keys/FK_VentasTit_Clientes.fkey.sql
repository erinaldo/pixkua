/****** Object:  ForeignKey [FK_VentasTit_Clientes]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[VentasTit]  WITH CHECK ADD  CONSTRAINT [FK_VentasTit_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [Sales].[Clientes] ([IdCliente])


GO
ALTER TABLE [Sales].[VentasTit] CHECK CONSTRAINT [FK_VentasTit_Clientes]

