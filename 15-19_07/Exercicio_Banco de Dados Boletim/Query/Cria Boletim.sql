CREATE TABLE [dbo].[Boletim]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Aluno] INT NOT NULL, 
    [Nota] INT NOT NULL, 
    [Turma] INT NOT NULL,
	[UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInt] DATETIME      DEFAULT (getdate()) NOT NULL,
    [DatAlt] DATETIME      DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [FK_Boletim_Nota] FOREIGN KEY ([Nota]) REFERENCES [Notas]([Id]),
	CONSTRAINT [FK_Boletim_Turma] FOREIGN KEY ([Turma]) REFERENCES [Turma]([Id])
)