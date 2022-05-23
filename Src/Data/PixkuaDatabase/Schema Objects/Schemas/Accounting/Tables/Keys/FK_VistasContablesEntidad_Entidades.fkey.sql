/****** Object:  ForeignKey [FK_VistasContablesEntidad_Entidades]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[VistasContablesEntidad]  WITH CHECK ADD  CONSTRAINT [FK_VistasContablesEntidad_Entidades] FOREIGN KEY([IdEntidad])
REFERENCES [Accounting].[Entidades] ([IdEntidad])


GO
ALTER TABLE [Accounting].[VistasContablesEntidad] CHECK CONSTRAINT [FK_VistasContablesEntidad_Entidades]

