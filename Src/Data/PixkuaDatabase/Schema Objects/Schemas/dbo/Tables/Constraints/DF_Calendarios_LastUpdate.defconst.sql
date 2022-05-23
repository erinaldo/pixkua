/****** Object:  Default [DF_Calendarios_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Calendarios] ADD  CONSTRAINT [DF_Calendarios_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


