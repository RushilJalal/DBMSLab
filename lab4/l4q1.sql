-- uses database from l3q1
-- 1
select count(*) from accident where extract(year from accd_date)=2008;

-- 2
select model, count(*)
from car natural join participated
where model='model1'
group by model;

-- 3
select name as OWNER_NAME, count(*) as No_of_Accidents, sum(damage_amount) as Total_Damage
from person natural join participated
group by name
order by Total_Damage desc;

-- 4
select name, count(*) as No_Of_Accidents
from person natural join participated
group by name
having count(*)=1;

-- 5
select name, driver_id, address
from person full outer join participated using(driver_id)
where report_number is null;
