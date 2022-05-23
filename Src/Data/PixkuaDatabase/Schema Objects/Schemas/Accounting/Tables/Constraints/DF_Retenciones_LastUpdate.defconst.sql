/****** Object:  Default [DF_Retenciones_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Retenciones] ADD  CONSTRAINT [DF_Retenciones_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


