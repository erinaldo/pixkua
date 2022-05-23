/****** Object:  Default [DF_Servicios_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[Servicios] ADD  CONSTRAINT [DF_Servicios_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


