/****** Object:  Default [DF_CentrosProduccionArticulos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[CentrosProduccionArticulos] ADD  CONSTRAINT [DF_CentrosProduccionArticulos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


