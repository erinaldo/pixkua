/****** Object:  Default [DF_Catalogos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Catalogos] ADD  CONSTRAINT [DF_Catalogos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


