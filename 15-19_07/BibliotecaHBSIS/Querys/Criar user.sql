CREATE TABLE [dbo].[Usuario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(150) NOT NULL, 
    [Login] VARCHAR(50) NOT NULL, 
    [Senha] VARCHAR(50) NOT NULL, 
    [E-mail] VARCHAR(150) NOT NULL, 
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL default getdate(),
    [DatAlt] DATETIME NOT NULL default getdate()
)
