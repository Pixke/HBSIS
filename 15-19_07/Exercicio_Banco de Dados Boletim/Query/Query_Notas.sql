insert into Notas
	(NomeAluno, Turma, Nota,  UsuInc, UsuAlt, DatInc, DatAlt)
	values
	(1, 1, 5, 1, 1, GETDATE(), GETDATE())
	go
select * from Notas