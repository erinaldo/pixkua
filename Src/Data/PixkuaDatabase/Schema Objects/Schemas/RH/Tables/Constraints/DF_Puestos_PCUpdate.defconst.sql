/****** Object:  Default [DF_Puestos_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [RH].[Puestos] ADD  CONSTRAINT [DF_Puestos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


