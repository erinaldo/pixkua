/****** Object:  Default [DF_Clientes_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Clientes] ADD  CONSTRAINT [DF_Clientes_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


