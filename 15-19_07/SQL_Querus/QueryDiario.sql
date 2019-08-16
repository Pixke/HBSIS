select temp.*,iif(temp.media >=7, 'Aprovado', 'Reprovado') from
	(select
		Nome,
		Materia,
		((Nota1+ Nota2+ Nota3)/3)as 'media'
	from Diario) temp;
	
select 
	Nome,
	Materia,
	((Nota1 + Nota2 + Nota3)/3) >=7, 'Aprovado', 'Reprovado' as 'Status'
	from Diario
	
