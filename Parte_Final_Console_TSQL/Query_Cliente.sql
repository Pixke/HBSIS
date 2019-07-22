insert into Clientes
	(Nome, Ativo, UsuInc, UsuAlt, DatInt, DatAlt)
	values
	('Afrodite', 1, 1, 1, GETDATE(), GETDATE())
	go
select * from Cliente