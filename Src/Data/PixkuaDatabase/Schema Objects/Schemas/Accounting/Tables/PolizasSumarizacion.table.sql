CREATE TABLE [Accounting].[PolizasSumarizacion](
	[IdPolizaSumarizacion] [int] NOT NULL,
	[Sumarizacion] [varchar](64) NOT NULL,
 CONSTRAINT [PK_PolizasSumarizacion] PRIMARY KEY CLUSTERED 
(
	[IdPolizaSumarizacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


