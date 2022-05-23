/****** Object:  Check [CK_NotasTit_Tipo]    Script Date: 12/07/2011 17:33:39 ******/
ALTER TABLE [Accounting].[NotasTit]  WITH CHECK ADD  CONSTRAINT [CK_NotasTit_Tipo] CHECK  (([Tipo]='A' OR [Tipo]='C'))


GO
ALTER TABLE [Accounting].[NotasTit] CHECK CONSTRAINT [CK_NotasTit_Tipo]

