/****** Object:  Default [DF_FormasPago_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[FormasPago] ADD  CONSTRAINT [DF_FormasPago_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


