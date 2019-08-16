CREATE TABLE [dbo].[Diario-1]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Aluno] VARCHAR(100) NOT NULL, 
    [Materia] VARCHAR(100) NOT NULL, 
    [Nota1] INT NOT NULL, 
    [Nota2] INT NOT NULL,
	[Nota3] INT NOT NULL,
	[Nota4] INT NOT NULL,
	[Nota5] INT NOT NULL,
	[Nota6] INT NOT NULL, 
    [Media] INT NOT NULL, 
    [Status] VARCHAR(100) NOT NULL,

)
