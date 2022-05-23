/****** Object:  Default [DF_Usuarios_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


