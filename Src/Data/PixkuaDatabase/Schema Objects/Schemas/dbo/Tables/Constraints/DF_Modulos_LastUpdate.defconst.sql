/****** Object:  Default [DF_Modulos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Modulos] ADD  CONSTRAINT [DF_Modulos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


