/****** Object:  Default [DF_Empresas_PCUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Empresas] ADD  CONSTRAINT [DF_Empresas_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


