/****** Object:  Default [DF_EmpresasConfig_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[EmpresasConfig] ADD  CONSTRAINT [DF_EmpresasConfig_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


