/****** Object:  Default [DF_Catalogos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Catalogos] ADD  CONSTRAINT [DF_Catalogos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


