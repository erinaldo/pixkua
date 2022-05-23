/****** Object:  Default [DF_Permisos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Politicas] ADD  CONSTRAINT [DF_Permisos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


