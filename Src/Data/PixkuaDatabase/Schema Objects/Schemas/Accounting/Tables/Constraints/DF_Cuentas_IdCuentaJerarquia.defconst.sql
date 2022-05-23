/****** Object:  Default [DF_Cuentas_IdCuentaJerarquia]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Cuentas] ADD  CONSTRAINT [DF_Cuentas_IdCuentaJerarquia]  DEFAULT ((1)) FOR [IdCuentaOrden]


