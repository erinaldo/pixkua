CREATE TABLE [dbo].[ProcesosFormas](
	[IdProcesoForma] [int] NOT NULL,
	[IdProceso] [int] NOT NULL,
	[Forma] [varchar](32) NOT NULL,
	[Ensamblado] [varchar](32) NOT NULL,
	[NameSpace] [varchar](128) NOT NULL,
	[Clase] [varchar](32) NOT NULL,
	[URL] [varchar](256) NOT NULL,
	[Inicial] [bit] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserCreate] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_ProcesosFormas] PRIMARY KEY CLUSTERED 
(
	[IdProcesoForma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


