/****** Object:  Default [DF_Modulos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Modulos] ADD  CONSTRAINT [DF_Modulos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


