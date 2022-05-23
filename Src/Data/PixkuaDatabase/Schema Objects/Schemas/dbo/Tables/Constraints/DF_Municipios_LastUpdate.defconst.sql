/****** Object:  Default [DF_Municipios_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Municipios] ADD  CONSTRAINT [DF_Municipios_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


