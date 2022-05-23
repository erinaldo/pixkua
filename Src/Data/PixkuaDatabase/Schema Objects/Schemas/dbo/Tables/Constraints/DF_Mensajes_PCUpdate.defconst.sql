/****** Object:  Default [DF_Mensajes_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Mensajes] ADD  CONSTRAINT [DF_Mensajes_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


