/****** Object:  Default [DF_EmpresasConfig_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[EmpresasConfig] ADD  CONSTRAINT [DF_EmpresasConfig_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


