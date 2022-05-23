/****** Object:  Default [DF_FormasPago_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[FormasPago] ADD  CONSTRAINT [DF_FormasPago_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


