/****** Object:  Default [DF_Regiones_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Regiones] ADD  CONSTRAINT [DF_Regiones_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


