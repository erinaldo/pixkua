/****** Object:  Default [DF_Empleados_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [RH].[Empleados] ADD  CONSTRAINT [DF_Empleados_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


