/****** Object:  Default [DF_Presupuestos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Presupuestos] ADD  CONSTRAINT [DF_Presupuestos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


