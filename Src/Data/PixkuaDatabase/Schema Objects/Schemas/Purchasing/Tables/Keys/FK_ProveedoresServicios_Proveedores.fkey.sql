/****** Object:  ForeignKey [FK_ProveedoresServicios_Proveedores]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresServicios]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresServicios_Proveedores] FOREIGN KEY([IdProveedor])
REFERENCES [Purchasing].[Proveedores] ([IdProveedor])


GO
ALTER TABLE [Purchasing].[ProveedoresServicios] CHECK CONSTRAINT [FK_ProveedoresServicios_Proveedores]

