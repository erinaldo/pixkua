/****** Object:  Default [DF_CentrosProduccion_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[CentrosProduccion] ADD  CONSTRAINT [DF_CentrosProduccion_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


