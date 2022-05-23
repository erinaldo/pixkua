CREATE TABLE [dbo].[GruposPoliticas](
	[IdGrupoPolitica] [int] IDENTITY(1,1) NOT NULL,
	[IdGrupo] [int] NOT NULL,
	[IdPolitica] [int] NOT NULL,
	[Aplica] [bit] NOT NULL,
 CONSTRAINT [PK_GruposPoliticas] PRIMARY KEY CLUSTERED 
(
	[IdGrupoPolitica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


