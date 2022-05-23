/****** Object:  Default [DF_PromocionesTipoSalida_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[PromocionesTipoSalida] ADD  CONSTRAINT [DF_PromocionesTipoSalida_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


