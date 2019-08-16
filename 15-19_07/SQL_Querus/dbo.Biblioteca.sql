CREATE TABLE [dbo].[Biblioteca] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Nome]    VARCHAR (100) NOT NULL,
    [Cep]     VARCHAR (100) NULL,
    [Ativa]   INT           NOT NULL,
    [UsuInc]  INT           NOT NULL,
    [UsuAlt]  INT           NOT NULL,
    [DataInc] DATE          NOT NULL,
    [DataAlt] DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

