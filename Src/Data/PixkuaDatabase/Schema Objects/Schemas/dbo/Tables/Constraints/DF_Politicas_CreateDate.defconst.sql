/****** Object:  Default [DF_Politicas_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Politicas] ADD  CONSTRAINT [DF_Politicas_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


