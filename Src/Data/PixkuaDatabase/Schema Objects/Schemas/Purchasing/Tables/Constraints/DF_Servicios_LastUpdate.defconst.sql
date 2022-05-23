/****** Object:  Default [DF_Servicios_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Servicios] ADD  CONSTRAINT [DF_Servicios_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


