/****** Object:  Default [DF_RemitentesMail_OverrideSMTPAuth]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[RemitentesMail] ADD  CONSTRAINT [DF_RemitentesMail_OverrideSMTPAuth]  DEFAULT ((1)) FOR [OverrideSMTPAuth]


