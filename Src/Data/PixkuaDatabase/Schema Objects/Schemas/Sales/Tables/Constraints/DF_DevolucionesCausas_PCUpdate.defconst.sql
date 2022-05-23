/****** Object:  Default [DF_DevolucionesCausas_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[DevolucionesCausas] ADD  CONSTRAINT [DF_DevolucionesCausas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


