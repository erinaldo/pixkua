/****** Object:  Default [DF_Marcas_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Marcas] ADD  CONSTRAINT [DF_Marcas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


