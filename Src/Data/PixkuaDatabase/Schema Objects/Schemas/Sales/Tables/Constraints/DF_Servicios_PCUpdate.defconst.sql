/****** Object:  Default [DF_Servicios_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Servicios] ADD  CONSTRAINT [DF_Servicios_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


