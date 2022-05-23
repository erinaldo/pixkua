/****** Object:  Default [DF_MensajesSys_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[MensajesSys] ADD  CONSTRAINT [DF_MensajesSys_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


