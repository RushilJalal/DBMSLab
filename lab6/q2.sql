-- Generate a trigger displaying driver information, on participating in an accident

set serveroutput on
create or replace trigger driver_info
after insert or update on participated
for each row

declare
d_name varchar(20);
d_address varchar(50);
d_id varchar(30); 

begin
select name, address, driver_id#
into d_name, d_address, d_id
from person natural join participated;

dbms_output.put_line('Driver name: ' || d_name);
dbms_output.put_line('Driver address: ' || d_address);
dbms_output.put_line('Driver id: ' || d_id);

end;
/