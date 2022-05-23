/****** Object:  Default [DF_Empresas_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Empresas] ADD  CONSTRAINT [DF_Empresas_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


