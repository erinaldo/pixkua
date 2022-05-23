/****** Object:  Default [DF_Impuestos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Impuestos] ADD  CONSTRAINT [DF_Impuestos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


