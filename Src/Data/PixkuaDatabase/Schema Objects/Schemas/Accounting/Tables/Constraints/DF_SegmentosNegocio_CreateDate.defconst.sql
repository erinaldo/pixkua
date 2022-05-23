/****** Object:  Default [DF_SegmentosNegocio_CreateDate]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[SegmentosNegocio] ADD  CONSTRAINT [DF_SegmentosNegocio_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]


