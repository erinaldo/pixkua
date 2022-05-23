/****** Object:  Default [DF_DepartamentosCentrosRecepcion_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCentrosRecepcion] ADD  CONSTRAINT [DF_DepartamentosCentrosRecepcion_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


