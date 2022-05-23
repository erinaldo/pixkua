/****** Object:  ForeignKey [FK_ClasificacionesArticulos_Clasificaciones]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ClasificacionesArticulos]  WITH CHECK ADD  CONSTRAINT [FK_ClasificacionesArticulos_Clasificaciones] FOREIGN KEY([IdClasificacion])
REFERENCES [Inventory].[Clasificaciones] ([IdClasificacion])


GO
ALTER TABLE [Inventory].[ClasificacionesArticulos] CHECK CONSTRAINT [FK_ClasificacionesArticulos_Clasificaciones]

