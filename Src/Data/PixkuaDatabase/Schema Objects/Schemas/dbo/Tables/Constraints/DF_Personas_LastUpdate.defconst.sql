/****** Object:  Default [DF_Personas_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


