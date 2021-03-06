CREATE UNIQUE CLUSTERED INDEX [UQ_AccesoGrupos] ON [Documents].[AccesoGrupos] 
(
	[IdGrupo] ASC,
	[IdTipo] ASC,
	[IdStatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]


