/****** Object:  Default [DF_Personas_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Personas_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


