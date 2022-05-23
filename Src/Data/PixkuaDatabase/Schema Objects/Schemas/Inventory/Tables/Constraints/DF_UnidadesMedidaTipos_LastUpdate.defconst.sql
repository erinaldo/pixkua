/****** Object:  Default [DF_UnidadesMedidaTipos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[UnidadesMedidaTipos] ADD  CONSTRAINT [DF_UnidadesMedidaTipos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


