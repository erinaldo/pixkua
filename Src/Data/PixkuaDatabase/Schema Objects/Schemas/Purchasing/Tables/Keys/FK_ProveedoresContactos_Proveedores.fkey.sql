/****** Object:  ForeignKey [FK_ProveedoresContactos_Proveedores]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresContactos]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresContactos_Proveedores] FOREIGN KEY([IdProveedor])
REFERENCES [Purchasing].[Proveedores] ([IdProveedor])


GO
ALTER TABLE [Purchasing].[ProveedoresContactos] CHECK CONSTRAINT [FK_ProveedoresContactos_Proveedores]

