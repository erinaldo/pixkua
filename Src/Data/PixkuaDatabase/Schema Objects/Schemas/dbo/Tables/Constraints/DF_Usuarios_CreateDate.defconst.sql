/****** Object:  Default [DF_Usuarios_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


