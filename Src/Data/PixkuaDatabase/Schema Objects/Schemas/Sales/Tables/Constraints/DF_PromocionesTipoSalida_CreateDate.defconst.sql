/****** Object:  Default [DF_PromocionesTipoSalida_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[PromocionesTipoSalida] ADD  CONSTRAINT [DF_PromocionesTipoSalida_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


