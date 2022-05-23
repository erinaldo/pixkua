/****** Object:  Default [DF_PropiedadesControles_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[PropiedadesControles] ADD  CONSTRAINT [DF_PropiedadesControles_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


