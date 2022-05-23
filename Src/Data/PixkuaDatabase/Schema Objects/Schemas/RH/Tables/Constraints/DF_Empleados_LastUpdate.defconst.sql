/****** Object:  Default [DF_Empleados_LastUpdate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [RH].[Empleados] ADD  CONSTRAINT [DF_Empleados_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]


