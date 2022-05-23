/****** Object:  Default [DF_Clientes_LimiteCredito]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Clientes] ADD  CONSTRAINT [DF_Clientes_LimiteCredito]  DEFAULT ((0)) FOR [LimiteCredito]


