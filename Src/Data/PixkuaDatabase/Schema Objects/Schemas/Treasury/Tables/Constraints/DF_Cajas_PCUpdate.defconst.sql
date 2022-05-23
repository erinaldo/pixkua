/****** Object:  Default [DF_Cajas_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Cajas] ADD  CONSTRAINT [DF_Cajas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


