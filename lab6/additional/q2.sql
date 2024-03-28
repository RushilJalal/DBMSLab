-- Generate a trigger intimating the driver regarding the accidents if the number of 
-- accidents by the driver reaches the count of two.

create or replace trigger accidentcount
after insert or update on participated
for each row

declare
accd_count number;
driver_id varchar(30);

begin
driver_id := :NEW.driver_id;

select count(*) into accd_count
from participated
where driver_id = driver_id;

if accd_count = 2 then
dbms_output.put_line('Alert: You have participated in 2 accidents!');
end if;

end;
/
