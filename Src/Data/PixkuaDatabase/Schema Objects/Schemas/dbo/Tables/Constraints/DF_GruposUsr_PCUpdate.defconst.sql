/****** Object:  Default [DF_GruposUsr_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[GruposUsr] ADD  CONSTRAINT [DF_GruposUsr_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


