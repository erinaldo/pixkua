/****** Object:  Default [DF_ArticulosStock_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ArticulosStock] ADD  CONSTRAINT [DF_ArticulosStock_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


