insert into Boletim
	(Aluno, Nota, Turma, UsuInc, UsuAlt, DatInt, DatAlt)
	values
	(1, 1, 1, 1, 1, GETDATE(), GETDATE())
	go
select * from Boletim