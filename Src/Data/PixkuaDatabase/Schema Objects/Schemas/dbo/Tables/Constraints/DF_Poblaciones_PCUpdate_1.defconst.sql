/****** Object:  Default [DF_Poblaciones_PCUpdate_1]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Poblaciones] ADD  CONSTRAINT [DF_Poblaciones_PCUpdate_1]  DEFAULT (host_name()) FOR [PCUpdate]


