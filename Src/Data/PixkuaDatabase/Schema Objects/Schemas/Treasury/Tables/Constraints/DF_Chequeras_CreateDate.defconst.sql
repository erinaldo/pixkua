/****** Object:  Default [DF_Chequeras_CreateDate]    Script Date: 12/07/2011 17:33:40 ******/
ALTER TABLE [Treasury].[Chequeras] ADD  CONSTRAINT [DF_Chequeras_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


