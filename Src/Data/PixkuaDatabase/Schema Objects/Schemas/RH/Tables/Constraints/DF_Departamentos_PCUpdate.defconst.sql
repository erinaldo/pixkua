/****** Object:  Default [DF_Departamentos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [RH].[Departamentos] ADD  CONSTRAINT [DF_Departamentos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


