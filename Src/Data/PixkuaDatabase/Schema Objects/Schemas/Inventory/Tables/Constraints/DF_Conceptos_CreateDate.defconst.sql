/****** Object:  Default [DF_Conceptos_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Inventory].[Conceptos] ADD  CONSTRAINT [DF_Conceptos_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


