/****** Object:  Default [DF_Procesos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Procesos] ADD  CONSTRAINT [DF_Procesos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


