/****** Object:  ForeignKey [FK_ClientesContactos_Clientes]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ClientesContactos]  WITH CHECK ADD  CONSTRAINT [FK_ClientesContactos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [Sales].[Clientes] ([IdCliente])


GO
ALTER TABLE [Sales].[ClientesContactos] CHECK CONSTRAINT [FK_ClientesContactos_Clientes]

