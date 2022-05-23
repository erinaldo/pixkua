/****** Object:  Default [DF_CentrosCostos_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CategoriasPresupuestales] ADD  CONSTRAINT [DF_CentrosCostos_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


