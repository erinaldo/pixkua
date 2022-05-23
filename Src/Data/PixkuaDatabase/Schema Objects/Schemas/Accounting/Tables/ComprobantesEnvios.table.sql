CREATE TABLE [Accounting].[ComprobantesEnvios](
	[IdCFDSerie] [int] NOT NULL,
	[Folio] [int] NOT NULL,
	[IdComprobanteDestino] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ComprobantesEnvios] PRIMARY KEY CLUSTERED 
(
	[IdCFDSerie] ASC,
	[Folio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'Accounting', @level1type=N'TABLE',@level1name=N'ComprobantesEnvios', @level2type=N'COLUMN',@level2name=N'IdComprobanteDestino'

