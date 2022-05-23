/****** Object:  Default [DF_GastosConceptos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Purchasing].[GastosConceptos] ADD  CONSTRAINT [DF_GastosConceptos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


