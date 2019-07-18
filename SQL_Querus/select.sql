select 
	Aluno,
	Idade,
	iif (Ativo = 1, 'Ativo', 'Inativo') as 'Status'
	from AulaCsharp
where id in

(SELECT id  FROM AulaCsharp where Idade >10)
order by id desc