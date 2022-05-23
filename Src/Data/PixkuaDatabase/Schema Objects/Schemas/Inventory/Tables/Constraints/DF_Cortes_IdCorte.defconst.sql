/****** Object:  Default [DF_Cortes_IdCorte]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Cortes] ADD  CONSTRAINT [DF_Cortes_IdCorte]  DEFAULT (newid()) FOR [IdCorte]


