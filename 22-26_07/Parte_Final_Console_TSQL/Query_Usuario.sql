insert into Usuario
	(Nome,UsuInc, UsuAlt, DatInt, DatAlt)
	values
	('Thor', 1, 1, GETDATE(), GETDATE())
	go
select * from Usuario