/****** Object:  Default [DF_CentrosRecepcionAccesos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CentrosRecepcionAccesos] ADD  CONSTRAINT [DF_CentrosRecepcionAccesos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


