select 
	Dog,
	sum (TotalVendas) as 'TotalVendas',
	month(DataVendas) as 'Mes'


from DogZezinho
where Id between 8 and 11
group by Dog, MONTH (DataVendas)
order by 'TotalVendas' desc