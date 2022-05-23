/****** Object:  Default [DF_CentrosConsumo_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[CentrosConsumo] ADD  CONSTRAINT [DF_CentrosConsumo_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


