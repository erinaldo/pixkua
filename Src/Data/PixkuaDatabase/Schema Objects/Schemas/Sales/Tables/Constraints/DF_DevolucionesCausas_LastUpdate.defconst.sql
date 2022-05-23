/****** Object:  Default [DF_DevolucionesCausas_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[DevolucionesCausas] ADD  CONSTRAINT [DF_DevolucionesCausas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


