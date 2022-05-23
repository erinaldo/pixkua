/****** Object:  Default [DF_Cajas_IdCorteActual]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[Cajas] ADD  CONSTRAINT [DF_Cajas_IdCorteActual]  DEFAULT (newid()) FOR [IdCorteActual]


