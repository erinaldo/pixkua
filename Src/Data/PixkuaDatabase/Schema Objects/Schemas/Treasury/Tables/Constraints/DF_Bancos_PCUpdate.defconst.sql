/****** Object:  Default [DF_Bancos_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Bancos] ADD  CONSTRAINT [DF_Bancos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


