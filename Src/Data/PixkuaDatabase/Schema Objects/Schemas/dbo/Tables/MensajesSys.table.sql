CREATE TABLE [dbo].[MensajesSys](
	[IdMensajeSys] [int] NOT NULL,
	[MensajeSys] [varchar](128) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_MensajesSys] PRIMARY KEY CLUSTERED 
(
	[IdMensajeSys] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


