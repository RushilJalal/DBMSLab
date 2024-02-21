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
SELECT p.name, COUNT(*) AS No_Of_Accidents, EXTRACT(YEAR FROM a.accd_date) AS accd_year
FROM person p
JOIN participated pa ON p.driver_id# = pa.driver_id#
JOIN accident a ON pa.report_number = a.report_number
GROUP BY p.name, EXTRACT(YEAR FROM a.accd_date)
HAVING COUNT(*) > 2;


-- 5
select name, driver_id#, address
from person full outer join participated using(driver_id#)
where report_number is null;
