/****** Object:  Default [DF_DepartamentosAccesos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[DepartamentosAccesos] ADD  CONSTRAINT [DF_DepartamentosAccesos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


