select
	[FoodTruckZezinho],
	  
	  (SUM(TotalVendas) / count(TotalVendas)) as 'TotalMediaMes',
	   Month (DataVendas) as 'Mes'

from [FoodTruckZezinho]
group by [FoodTruckZezinho], Month (DataVendas)
order by TotalMediaMes desc


