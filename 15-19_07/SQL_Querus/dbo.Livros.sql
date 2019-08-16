CREATE TABLE [dbo].[Livros] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [NomeLivro]   VARCHAR (100) NOT NULL,
    [Autor]       VARCHAR (100) NULL,
    [Alocado]     BIT           NOT NULL,
    [BibliotecaX] NCHAR (10)    NOT NULL,
    [UsuInc]      INT           NOT NULL,
    [UsuAlt]      INT           NOT NULL,
    [DataInc]     DATE          NOT NULL,
    [DataAlt]     DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Biblioteca_UsuarioInc] FOREIGN KEY ([UsuInc]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_Biblioteca_UsuarioAlt] FOREIGN KEY ([UsuAlt]) REFERENCES [dbo].[Usuario] ([Id])
);

