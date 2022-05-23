/****** Object:  Default [DF_ListasPrecios_IdEmpresa]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ListasPrecios] ADD  CONSTRAINT [DF_ListasPrecios_IdEmpresa]  DEFAULT ((1)) FOR [IdEmpresa]


