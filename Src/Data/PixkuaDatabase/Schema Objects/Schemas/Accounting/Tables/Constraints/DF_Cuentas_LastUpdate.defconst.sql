/****** Object:  Default [DF_Cuentas_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Cuentas] ADD  CONSTRAINT [DF_Cuentas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


