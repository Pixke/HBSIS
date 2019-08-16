select 
		BL.Nome,
		count (LV.Id) as 'QuantLivros',
		US.Nome as 'UserNAme'
from Biblioteca BL
inner join Livros LV on BL.Id = LV.BibliotecaX
inner join Usuario US on LV.UsuInc = US.Id
group by BL.Nome, US.Nome