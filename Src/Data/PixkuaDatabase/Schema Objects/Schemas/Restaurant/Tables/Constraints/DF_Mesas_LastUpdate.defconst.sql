/****** Object:  Default [DF_Mesas_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Mesas] ADD  CONSTRAINT [DF_Mesas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


