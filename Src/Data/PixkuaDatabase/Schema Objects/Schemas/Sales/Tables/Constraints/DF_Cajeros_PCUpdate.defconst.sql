/****** Object:  Default [DF_Cajeros_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Cajeros] ADD  CONSTRAINT [DF_Cajeros_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


