/****** Object:  ForeignKey [FK_Sucursales_Poblaciones]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Sucursales]  WITH CHECK ADD  CONSTRAINT [FK_Sucursales_Poblaciones] FOREIGN KEY([IdPoblacion])
REFERENCES [dbo].[Poblaciones] ([IdPoblacion])


GO
ALTER TABLE [dbo].[Sucursales] CHECK CONSTRAINT [FK_Sucursales_Poblaciones]

