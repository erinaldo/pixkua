/****** Object:  Default [DF_CentrosConsumo_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[CentrosConsumo] ADD  CONSTRAINT [DF_CentrosConsumo_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


