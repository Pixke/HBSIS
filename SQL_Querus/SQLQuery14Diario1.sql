select 
	  Nome,
	  Materia,
	  
	  (SUM(Nota) / count(Nota)) as 'Media',
	  ---Soma		---Média
	  count (Nota) as 'Prova'

from [100xNotas]
group by Nome, Materia
