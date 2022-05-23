/****** Object:  Default [DF_DepartamentosGastoConceptos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosGastosConceptos] ADD  CONSTRAINT [DF_DepartamentosGastoConceptos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


