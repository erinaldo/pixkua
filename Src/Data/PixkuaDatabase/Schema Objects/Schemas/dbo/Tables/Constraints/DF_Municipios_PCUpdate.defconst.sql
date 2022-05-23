/****** Object:  Default [DF_Municipios_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Municipios] ADD  CONSTRAINT [DF_Municipios_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


