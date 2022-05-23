/****** Object:  Default [DF_Polizas_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[PolizasPerfiles] ADD  CONSTRAINT [DF_Polizas_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


