CREATE TABLE [dbo].[Notas] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [NomeAluno] INT      NOT NULL,
    [Turma]     INT      NOT NULL,
    [Nota]      INT      NOT NULL,
	[Presenca]  bit		 NOT NULL,
    [UsuInc]    INT      NOT NULL,
    [UsuAlt]    INT      NOT NULL,
    [DatInc]    DATETIME DEFAULT (getdate()) NOT NULL,
    [DatAlt]    DATETIME DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_Aluno] FOREIGN KEY ([NomeAluno]) REFERENCES [dbo].[Alunos] ([Id]),
    CONSTRAINT [FK_Notas_Turma] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Alunos] ([Id])
);

