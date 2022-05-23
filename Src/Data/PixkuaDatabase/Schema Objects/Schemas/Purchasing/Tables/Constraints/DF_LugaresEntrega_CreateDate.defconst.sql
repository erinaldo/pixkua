/****** Object:  Default [DF_LugaresEntrega_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[CentrosRecepcion] ADD  CONSTRAINT [DF_LugaresEntrega_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


