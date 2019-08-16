select 
	LV.Id,
	LV.NomeLivro,
	iif(LV.Alocado=1, 'Sim', 'Não') as 'Alocado',
	BL.Nome as 'Nome Biblioteca'

from Biblioteca BL
inner join Livros LV on BL.Id = LV.BibliotecaX