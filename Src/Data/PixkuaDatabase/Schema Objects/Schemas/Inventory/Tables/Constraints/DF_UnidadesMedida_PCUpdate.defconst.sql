/****** Object:  Default [DF_UnidadesMedida_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[UnidadesMedida] ADD  CONSTRAINT [DF_UnidadesMedida_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


