select
sum (Valor * Quantidade) as 'Valor Total', CONCAT(month (DatInc),'/', YEAR (DatInc)) as 'Mês/Ano'
from Vendas 
group by CONCAT(month (DatInc),'/', YEAR (DatInc)) 
order by [Valor Total] desc

--Trazer o mês de cada ano que retornou a maior quantidade de vendas
-- Tradução "Retornar agrupado por mês a quantidade de vendas e ordernar do maior para menor"