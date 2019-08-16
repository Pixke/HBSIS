insert into Alunos
	(Nome, Turma, Ativo, UsuInc, UsuAlt, DatInt, DatAlt)
	values
	('Nani', 1, 1, 1, 1, GETDATE(), GETDATE())
	go
select * from Alunos