/****** Object:  Default [DF_Usuarios_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


