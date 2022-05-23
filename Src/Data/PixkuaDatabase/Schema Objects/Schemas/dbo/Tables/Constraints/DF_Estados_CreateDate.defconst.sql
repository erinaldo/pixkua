/****** Object:  Default [DF_Estados_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Estados] ADD  CONSTRAINT [DF_Estados_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


