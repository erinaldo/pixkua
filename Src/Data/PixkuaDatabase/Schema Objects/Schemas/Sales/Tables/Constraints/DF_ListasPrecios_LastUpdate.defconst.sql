/****** Object:  Default [DF_ListasPrecios_LastUpdate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ListasPrecios] ADD  CONSTRAINT [DF_ListasPrecios_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


