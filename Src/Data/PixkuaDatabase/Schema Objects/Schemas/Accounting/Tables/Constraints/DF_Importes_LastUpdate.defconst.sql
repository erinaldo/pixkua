/****** Object:  Default [DF_Importes_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Importes] ADD  CONSTRAINT [DF_Importes_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


