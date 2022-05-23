/****** Object:  ForeignKey [FK_CategoriasPresupuestalesServicios_Servicios]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CategoriasPresupuestalesServicios]  WITH CHECK ADD  CONSTRAINT [FK_CategoriasPresupuestalesServicios_Servicios] FOREIGN KEY([IdServicio])
REFERENCES [Purchasing].[Servicios] ([IdServicio])


GO
ALTER TABLE [Purchasing].[CategoriasPresupuestalesServicios] CHECK CONSTRAINT [FK_CategoriasPresupuestalesServicios_Servicios]

