/****** Object:  Default [DF_ZonasVenta_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Sales].[ZonasVenta] ADD  CONSTRAINT [DF_ZonasVenta_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


