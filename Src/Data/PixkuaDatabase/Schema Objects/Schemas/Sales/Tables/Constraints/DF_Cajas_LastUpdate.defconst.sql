/****** Object:  Default [DF_Cajas_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Cajas] ADD  CONSTRAINT [DF_Cajas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


