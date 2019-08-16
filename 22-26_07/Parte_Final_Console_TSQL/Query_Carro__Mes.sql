select c.Carro, COUNT (l.Carro) as 'Quantidade',
year (l.DatInc) as 'Ano',
month (l.DatInc) as 'Mês'
from Locacao l 

inner join Carros c on l.Carro = c.Id

where l.Devolucao between '2019/01/01' and '2019/12/31'

group by c.Carro, month(l.DatInc), year(l.DatInc)