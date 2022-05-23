CREATE TABLE [dbo].[Configuracion](
	[IdConfiguracion] [int] IDENTITY(1,1) NOT NULL,
	[Path] [varchar](256) NOT NULL,
	[Key] [varchar](64) NOT NULL,
	[Value] [varchar](256) NOT NULL,
 CONSTRAINT [PK_Configuracion] PRIMARY KEY NONCLUSTERED 
(
	[IdConfiguracion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


