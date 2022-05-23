/****** Object:  Default [DF_DevolucionesTit_IdCorte]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[DevolucionesTit] ADD  CONSTRAINT [DF_DevolucionesTit_IdCorte]  DEFAULT ([dbo].[fxEmptyID]()) FOR [IdCorte]


