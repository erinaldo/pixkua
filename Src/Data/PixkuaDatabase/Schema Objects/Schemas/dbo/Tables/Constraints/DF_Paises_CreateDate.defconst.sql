/****** Object:  Default [DF_Paises_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Paises] ADD  CONSTRAINT [DF_Paises_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


