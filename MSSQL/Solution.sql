-- 1st Task
select Cars.Name 
from Cars
inner join Cars as parents on Cars.[BaseID] = parents.[ID]
where Cars.[BaseID] is not null and Cars.[BrandID] = parents.[BrandID];
--2nd Task
select Brands.[Name]
from Cars
left join Brands on Cars.[BrandID] = Brands.[ID]
group by Cars.[BrandID], Brands.[Name]
having count(*) > 3;
--3rd Task
select Brands.[Name], SUM(PRICE) as 'Price Summary'
from Cars
left join Brands on Cars.[BrandID] = Brands.[ID]
group by Cars.[BrandID], Brands.[Name];
--4th Task
select TOP (2) Brands.[Name], AVG(Pow) as 'Average Power'
from Cars
left join Brands on Cars.[BrandID] = Brands.[ID]
group by Cars.[BrandID], Brands.[Name]
order by AVG(Pow) desc;
--5th Task
select o.[Name] as 'Car Name', Brands.[Name] as 'Brand Name'
from Cars o                    
left join Cars b on o.[BrandID] = b.[BrandID] AND o.[Price] > b.[Price]
left join Brands on o.[BrandID] = Brands.[ID]
WHERE b.[Price] is NULL;