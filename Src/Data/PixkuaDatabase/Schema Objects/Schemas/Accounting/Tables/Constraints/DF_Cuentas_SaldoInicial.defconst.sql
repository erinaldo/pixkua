/****** Object:  Default [DF_Cuentas_SaldoInicial]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Cuentas] ADD  CONSTRAINT [DF_Cuentas_SaldoInicial]  DEFAULT ((0)) FOR [SaldoInicial]


