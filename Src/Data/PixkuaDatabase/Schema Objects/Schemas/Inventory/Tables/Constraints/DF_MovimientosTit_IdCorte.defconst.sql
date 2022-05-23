/****** Object:  Default [DF_MovimientosTit_IdCorte]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[MovimientosTit] ADD  CONSTRAINT [DF_MovimientosTit_IdCorte]  DEFAULT ([dbo].[fxEmptyID]()) FOR [IdCorte]


