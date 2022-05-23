/****** Object:  Default [DF_Presupuestos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Presupuestos] ADD  CONSTRAINT [DF_Presupuestos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


