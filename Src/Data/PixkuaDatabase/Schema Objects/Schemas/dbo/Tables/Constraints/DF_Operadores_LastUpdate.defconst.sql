/****** Object:  Default [DF_Operadores_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Operadores] ADD  CONSTRAINT [DF_Operadores_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


