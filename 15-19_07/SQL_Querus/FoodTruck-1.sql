select
	Dog,
	  SUM(TotalVendas) as 'TotalMediaMes',
	  Month(DataVendas) as 'Mes'
from DogZezinho
group by Dog, Month(DataVendas)
order by TotalMediaMes desc 