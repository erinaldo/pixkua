/****** Object:  ForeignKey [FK_Sucursales_Empresas]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Sucursales]  WITH NOCHECK ADD  CONSTRAINT [FK_Sucursales_Empresas] FOREIGN KEY([IdEmpresa])
REFERENCES [dbo].[Empresas] ([IdEmpresa])


GO
ALTER TABLE [dbo].[Sucursales] CHECK CONSTRAINT [FK_Sucursales_Empresas]

