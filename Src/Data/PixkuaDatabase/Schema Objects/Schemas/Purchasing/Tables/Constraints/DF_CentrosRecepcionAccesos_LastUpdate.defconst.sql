/****** Object:  Default [DF_CentrosRecepcionAccesos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CentrosRecepcionAccesos] ADD  CONSTRAINT [DF_CentrosRecepcionAccesos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


