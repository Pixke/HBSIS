CREATE TABLE [dbo].[Locacao]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Livro] INT NOT NULL, 
    [Usuario] INT NOT NULL,
	[Tipo] INT NOT NULL,
	[Devolucao] DATETIME NOT NULL,
	[Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL DEFAULT GETDATE(), 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Locacao_Livros] FOREIGN KEY ([Livro]) REFERENCES [Livros]([Id]),
	CONSTRAINT [FK_Locacao_UsuarioAloc] FOREIGN KEY ([Usuario]) REFERENCES [Usuario]([Id]),
	CONSTRAINT [FK_Locacao_LocacaoUsuInc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuario]([Id]),
	CONSTRAINT [FK_Locacao_LocacaoUsuAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuario]([Id]),
)
