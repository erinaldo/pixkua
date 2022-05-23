/****** Object:  Default [DF_Personas_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


