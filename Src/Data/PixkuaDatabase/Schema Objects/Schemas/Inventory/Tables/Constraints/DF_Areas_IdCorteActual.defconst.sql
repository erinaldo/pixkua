/****** Object:  Default [DF_Areas_IdCorteActual]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Areas] ADD  CONSTRAINT [DF_Areas_IdCorteActual]  DEFAULT ([dbo].[fxEmptyID]()) FOR [IdCorteActual]


