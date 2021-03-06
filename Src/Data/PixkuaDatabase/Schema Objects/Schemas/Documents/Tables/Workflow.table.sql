CREATE TABLE [Documents].[Workflow](
	[IdWorkflow] [int] IDENTITY(1,1) NOT NULL,
	[IdDocumentoTipo] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[Secuencia] [smallint] NOT NULL,
 CONSTRAINT [PK_Workflow] PRIMARY KEY CLUSTERED 
(
	[IdWorkflow] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


