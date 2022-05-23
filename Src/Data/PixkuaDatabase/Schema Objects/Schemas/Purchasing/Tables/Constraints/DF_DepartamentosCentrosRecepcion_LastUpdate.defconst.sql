/****** Object:  Default [DF_DepartamentosCentrosRecepcion_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosCentrosRecepcion] ADD  CONSTRAINT [DF_DepartamentosCentrosRecepcion_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


