insert into Carros
	(Nome, Modelo, Ano, Ativo, UsuInc, UsuAlt, DatInt, DatAlt)
	values
	('Ka', 'Sedan', 2012, 1, 1, 1, GETDATE(), GETDATE())
	go
select * from Carros