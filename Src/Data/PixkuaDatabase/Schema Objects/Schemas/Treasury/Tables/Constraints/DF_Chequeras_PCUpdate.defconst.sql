/****** Object:  Default [DF_Chequeras_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Chequeras] ADD  CONSTRAINT [DF_Chequeras_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


