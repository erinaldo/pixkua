/****** Object:  Default [DF_Marcas_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Marcas] ADD  CONSTRAINT [DF_Marcas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


