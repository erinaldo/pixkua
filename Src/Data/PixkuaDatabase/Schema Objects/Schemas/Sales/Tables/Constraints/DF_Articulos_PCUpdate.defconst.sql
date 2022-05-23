/****** Object:  Default [DF_Articulos_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Articulos] ADD  CONSTRAINT [DF_Articulos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


