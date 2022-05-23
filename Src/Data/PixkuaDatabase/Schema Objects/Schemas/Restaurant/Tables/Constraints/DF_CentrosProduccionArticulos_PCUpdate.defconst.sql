/****** Object:  Default [DF_CentrosProduccionArticulos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[CentrosProduccionArticulos] ADD  CONSTRAINT [DF_CentrosProduccionArticulos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


