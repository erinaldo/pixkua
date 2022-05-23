/****** Object:  Default [DF_ProcesosFormas_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[ProcesosFormas] ADD  CONSTRAINT [DF_ProcesosFormas_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


