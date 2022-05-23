/****** Object:  Default [DF_Modulos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Modulos] ADD  CONSTRAINT [DF_Modulos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


