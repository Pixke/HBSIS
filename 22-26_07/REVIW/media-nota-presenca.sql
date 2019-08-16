---select tr.Nome as 'Turma',
---	a.Aluno
---
---	from Turmas tr
---	inner join TurmaAlunos ta on tr.Id = ta.[Turma]
---	inner join Alunos a on ta.Aluno = a.Id;
--- trago todos os alunos da turma

select
	d.[Data],
	tr.Aluno,
	n.Nota as 'Média',
	ISNULL (n.Nota, 0) as 'Nota',
	IIF (count(p.Id) = 1, 'Presente', 'Ausente') as 'Presenças'
from Diarios d
	inner join TurmaAlunos tr on d.Turma = tr.Turma
	left join Presenca p on d.Id = p.Diarios and tr.Aluno = p.Aluno
	left join Notas n on tr.Aluno = n.Aluno and d.Id = n.Diario

group by d.[Data], n.Nota, tr.Aluno