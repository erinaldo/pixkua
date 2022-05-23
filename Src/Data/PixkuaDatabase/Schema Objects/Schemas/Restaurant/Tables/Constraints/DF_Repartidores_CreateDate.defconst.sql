/****** Object:  Default [DF_Repartidores_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Repartidores] ADD  CONSTRAINT [DF_Repartidores_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


