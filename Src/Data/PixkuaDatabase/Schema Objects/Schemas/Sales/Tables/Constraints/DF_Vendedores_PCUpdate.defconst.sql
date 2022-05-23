/****** Object:  Default [DF_Vendedores_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Vendedores] ADD  CONSTRAINT [DF_Vendedores_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


