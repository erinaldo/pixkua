/****** Object:  Default [DF_TiposCambio_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[TiposCambio] ADD  CONSTRAINT [DF_TiposCambio_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


