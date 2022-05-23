/****** Object:  Default [DF_ArticulosStock_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[ArticulosStock] ADD  CONSTRAINT [DF_ArticulosStock_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


