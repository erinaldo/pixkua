/****** Object:  Default [DF_Gastos_Modalidad]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Gastos] ADD  CONSTRAINT [DF_Gastos_Modalidad]  DEFAULT ('R') FOR [ModalidadPago]


