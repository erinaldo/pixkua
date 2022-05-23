/****** Object:  Default [DF_Catalogos_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Catalogos] ADD  CONSTRAINT [DF_Catalogos_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


