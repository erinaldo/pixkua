/****** Object:  Default [DF_CentrosProduccion_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[CentrosProduccion] ADD  CONSTRAINT [DF_CentrosProduccion_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


