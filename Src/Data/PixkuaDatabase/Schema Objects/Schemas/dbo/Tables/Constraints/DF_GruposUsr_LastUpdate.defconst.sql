/****** Object:  Default [DF_GruposUsr_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[GruposUsr] ADD  CONSTRAINT [DF_GruposUsr_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


