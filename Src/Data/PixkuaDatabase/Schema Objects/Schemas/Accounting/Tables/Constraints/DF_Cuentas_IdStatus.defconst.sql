/****** Object:  Default [DF_Cuentas_IdStatus]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Cuentas] ADD  CONSTRAINT [DF_Cuentas_IdStatus]  DEFAULT ((1)) FOR [IdStatus]


