/****** Object:  Default [DF_CuentasJerarquias_IdEmpresa]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[CuentasOrden] ADD  CONSTRAINT [DF_CuentasJerarquias_IdEmpresa]  DEFAULT ((1)) FOR [IdEmpresa]


