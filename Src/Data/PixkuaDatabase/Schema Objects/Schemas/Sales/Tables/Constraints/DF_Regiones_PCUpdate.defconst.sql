/****** Object:  Default [DF_Regiones_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Regiones] ADD  CONSTRAINT [DF_Regiones_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


