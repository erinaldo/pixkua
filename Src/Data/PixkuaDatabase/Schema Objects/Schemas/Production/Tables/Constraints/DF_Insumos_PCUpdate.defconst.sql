/****** Object:  Default [DF_Insumos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Production].[Insumos] ADD  CONSTRAINT [DF_Insumos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


