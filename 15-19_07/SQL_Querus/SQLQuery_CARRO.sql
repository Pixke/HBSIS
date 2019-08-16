
select 
	  Modelo,
	  NumeroDeVendas,
	  DataDeVenda,
	  
	  (SUM(NumeroDeVendas) / count(*)) as 'Media'
	  ---Soma		---Média
from Carro

group by Modelo, DataDeVenda,NumeroDeVendas