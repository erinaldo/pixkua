/****** Object:  Default [DF_Cuentas_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Cuentas] ADD  CONSTRAINT [DF_Cuentas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


