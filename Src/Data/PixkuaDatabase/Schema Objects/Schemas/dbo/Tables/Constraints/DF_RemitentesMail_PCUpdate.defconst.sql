/****** Object:  Default [DF_RemitentesMail_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[RemitentesMail] ADD  CONSTRAINT [DF_RemitentesMail_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


