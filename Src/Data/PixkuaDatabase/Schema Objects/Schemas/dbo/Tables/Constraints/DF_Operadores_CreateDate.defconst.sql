/****** Object:  Default [DF_Operadores_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Operadores] ADD  CONSTRAINT [DF_Operadores_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


