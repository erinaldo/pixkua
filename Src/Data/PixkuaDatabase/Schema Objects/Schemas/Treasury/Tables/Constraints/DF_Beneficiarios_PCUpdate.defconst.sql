/****** Object:  Default [DF_Beneficiarios_PCUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Beneficiarios] ADD  CONSTRAINT [DF_Beneficiarios_PCUpdate]  DEFAULT (host_name()) FOR [PCUpdate]


