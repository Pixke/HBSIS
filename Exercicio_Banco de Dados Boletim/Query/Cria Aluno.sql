CREATE TABLE [dbo].[Alunos] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Nome]   VARCHAR (150) NOT NULL,
    [Turma]  INT           NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatInt] DATETIME      DEFAULT (getdate()) NOT NULL,
    [DatAlt] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);