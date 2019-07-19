CREATE TABLE [dbo].[Livros] 
(
    [Id] INT NOT NULL IDENTITY,
	[Registro] INT NOT NULL,
    [Titulo] VARCHAR(1200) NOT NULL, 
    [ISBN] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [Sinopse] NVARCHAR(MAX) NOT NULL, 
    [Observacoes] VARCHAR(1000) NULL, 
	[Ativo] bit NOT NULL,
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInt] DATETIME DEFAULT getdate() NOT NULL,
    [DatAlt] DATETIME DEFAULT getdate() NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Livros_To_Genero] FOREIGN KEY ([Genero]) REFERENCES [Generos]([Id]), 
    CONSTRAINT [FK_Livros_To_Editora] FOREIGN KEY ([Editora]) REFERENCES [Editora]([Id]), 
    CONSTRAINT [FK_Livros_To_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuario]([Id]), 
    CONSTRAINT [FK_Livros_To_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuario]([Id]),
);

