/****** Object:  Default [DF_ListasPrecios_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ListasPrecios] ADD  CONSTRAINT [DF_ListasPrecios_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


