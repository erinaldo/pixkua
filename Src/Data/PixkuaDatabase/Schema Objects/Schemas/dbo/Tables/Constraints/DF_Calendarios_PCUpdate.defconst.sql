/****** Object:  Default [DF_Calendarios_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Calendarios] ADD  CONSTRAINT [DF_Calendarios_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


