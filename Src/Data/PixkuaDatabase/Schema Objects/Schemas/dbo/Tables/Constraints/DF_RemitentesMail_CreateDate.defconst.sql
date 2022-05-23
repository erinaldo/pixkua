/****** Object:  Default [DF_RemitentesMail_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[RemitentesMail] ADD  CONSTRAINT [DF_RemitentesMail_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


