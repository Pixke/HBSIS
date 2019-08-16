insert into Usuario
	(Nome, [Login], Senha, UsuInc, UsuAlt, DatInc, DatAlt)
	values
	('Admin', 'Zeus', 'abcd&12345', 1, 1, GETDATE(), GETDATE())
	go
select * from Usuario