/****** Object:  Default [DF_Meseros_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Restaurant].[Meseros] ADD  CONSTRAINT [DF_Meseros_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


