/****** Object:  Default [DF_PedidosTipos_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[PedidosTipos] ADD  CONSTRAINT [DF_PedidosTipos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


