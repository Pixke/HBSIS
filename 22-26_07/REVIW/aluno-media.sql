select

	a.Aluno,
	sum (n.Nota) / count (d.[Data]) as 'Média'

from Alunos a
	inner join TurmaAlunos tr on a.Id = tr.Aluno
	inner join Diarios d on tr.Turma = d.Turma
	left join Notas n on d.Id = n.Diario and d.Id = n.Aluno

where tr.Turma = 1
group by a.Aluno

