/****** Object:  Default [DF_LugaresEntrega_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CentrosRecepcion] ADD  CONSTRAINT [DF_LugaresEntrega_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


