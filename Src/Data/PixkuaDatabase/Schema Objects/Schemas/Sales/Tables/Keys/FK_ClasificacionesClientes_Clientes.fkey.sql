/****** Object:  ForeignKey [FK_ClasificacionesClientes_Clientes]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ClasificacionesClientes]  WITH CHECK ADD  CONSTRAINT [FK_ClasificacionesClientes_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [Sales].[Clientes] ([IdCliente])


GO
ALTER TABLE [Sales].[ClasificacionesClientes] CHECK CONSTRAINT [FK_ClasificacionesClientes_Clientes]

