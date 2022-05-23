/****** Object:  ForeignKey [FK_ProveedoresServicios_Servicios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[ProveedoresServicios]  WITH CHECK ADD  CONSTRAINT [FK_ProveedoresServicios_Servicios] FOREIGN KEY([IdServicio])
REFERENCES [Purchasing].[Servicios] ([IdServicio])


GO
ALTER TABLE [Purchasing].[ProveedoresServicios] CHECK CONSTRAINT [FK_ProveedoresServicios_Servicios]

