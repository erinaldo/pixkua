/****** Object:  Default [DF_Beneficiarios_IdStatus]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Beneficiarios] ADD  CONSTRAINT [DF_Beneficiarios_IdStatus]  DEFAULT ((1)) FOR [IdStatus]


