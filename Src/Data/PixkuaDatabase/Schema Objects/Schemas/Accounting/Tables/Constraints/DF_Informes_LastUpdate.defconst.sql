/****** Object:  Default [DF_Informes_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[Informes] ADD  CONSTRAINT [DF_Informes_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


