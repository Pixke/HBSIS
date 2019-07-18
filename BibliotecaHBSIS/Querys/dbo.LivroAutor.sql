CREATE TABLE [dbo].[LivroAutor] (
    [Id]    INT NOT NULL,
    [Livro] INT NULL,
    [Autor] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_LivroAutor_Livros] FOREIGN KEY ([Livro]) REFERENCES [Livros]([Id]),
	CONSTRAINT [FK_LivroAutor_Autores] FOREIGN KEY ([Autor]) REFERENCES [Autores]([Id])
);

