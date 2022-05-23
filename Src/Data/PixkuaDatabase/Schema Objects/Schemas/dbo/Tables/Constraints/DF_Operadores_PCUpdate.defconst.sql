/****** Object:  Default [DF_Operadores_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Operadores] ADD  CONSTRAINT [DF_Operadores_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


