insert into Turma
	(Turma, UsuInc, UsuAlt, DatInc, DatAlt)
	values
	('HBSIS', 1, 1, GETDATE(), GETDATE())
	go
select * from Turma