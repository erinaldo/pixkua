/****** Object:  Default [DF_ArticulosStock_IdEmpresa]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ArticulosStock] ADD  CONSTRAINT [DF_ArticulosStock_IdEmpresa]  DEFAULT ((1)) FOR [IdEmpresa]


