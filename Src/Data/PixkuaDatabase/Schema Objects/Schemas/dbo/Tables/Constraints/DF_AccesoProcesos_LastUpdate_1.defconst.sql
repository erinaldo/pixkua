/****** Object:  Default [DF_AccesoProcesos_LastUpdate_1]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[AccesoProcesos] ADD  CONSTRAINT [DF_AccesoProcesos_LastUpdate_1]  DEFAULT (getdate()) FOR [LastUpdate]


