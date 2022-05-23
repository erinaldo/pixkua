/****** Object:  Default [DF_Status_UserCreate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Documents].[Status] ADD  CONSTRAINT [DF_Status_UserCreate]  DEFAULT ((0)) FOR [UserCreate]


