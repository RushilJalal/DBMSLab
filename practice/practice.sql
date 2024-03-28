select
    e1.employee_id,
    e1.name,
    COUNT(e2.employee_id) AS reports_count,
    ROUND(AVG(e2.age)) AS average_age
FROM employees e1 LEFT JOIN employees e2 ON e1.employee_id = e2.reports_to
GROUP BY e1.employee_id, e1.name
HAVING COUNT(e2.employee_id) > 0
order by e1.employee_id;

declare
    names employees.name%type;
begin
    select name
    into names
    from employees
    where age = 41;
    dbms_output.put_line(names);
    end;
   /

declare
emp_details employees%rowtype;
emp_name emp_details.name%type;
begin
emp_name:=&emp_name;
select *
into emp_details 
from employees
where name=emp_name;
dbms_output.put_line('Name: '||emp_details.name);
dbms_output.put_line('ID: '||emp_details.employee_id);
end;
/

declare
num number;
message varchar(20);
begin
num:=&num;
if num > 10 then
message:='greater than 10';
elsif num < 0 then
message:='lesser than 0';
else
message:='between 0, 10';
end if;
dbms_output.put_line(message);
end;
/

declare
grade varchar(1);
message varchar(20);
begin
grade:=&grade;
case grade
when 'a' 
then message:='grade A';
else 
message:='too bad';
end case;
dbms_output.put_line(message);
end;
/

declare
num number;
i int;
begin
i:=1;
num:=&num;
while i < 10 LOOP
dbms_output.put_line(num*i);
i:=i+1;
end LOOP;
end;
/

create or replace function add_numbers
(num1 number, num2 number)
return number
is
result number;
begin
result:=num1+num2;
return result;
end add_numbers;
/

create or replace PROCEDURE emp_details
(emp_id in employees.employee_id%type)
is
emp_record employees%rowtype;
begin
select name, reports_to, age, employee_id
into emp_record.name, emp_record.reports_to, emp_record.age, emp_record.employee_id
from employees
where employee_id=emp_id;
dbms_output.put_line(emp_record.name);
end emp_details;
/

CREATE OR REPLACE PROCEDURE get_employee_info(p_employee_id IN employees.employee_id%TYPE) IS
  emp_record employees%ROWTYPE;
BEGIN
  -- Use exception block to handle NO_DATA_FOUND
  BEGIN
    SELECT employee_id, name, reports_to, age
    INTO emp_record.employee_id, emp_record.name, emp_record.reports_to, emp_record.age
    FROM employees
    WHERE employee_id = p_employee_id;

    -- Output employee details if found
    DBMS_OUTPUT.PUT_LINE('Employee ID: ' || emp_record.employee_id);
    DBMS_OUTPUT.PUT_LINE('Employee Name: ' || emp_record.name);
    DBMS_OUTPUT.PUT_LINE('Reports To: ' || emp_record.reports_to);
    DBMS_OUTPUT.PUT_LINE('Age: ' || emp_record.age);
  EXCEPTION
    WHEN NO_DATA_FOUND THEN
      DBMS_OUTPUT.PUT_LINE('Employee not found for ID: ' || p_employee_id);
  END;
END get_employee_info;
/

create or replace trigger change_age
after update on employees
for each row
begin
dbms_output.put_line('Old age: '||:old.age);
dbms_output.put_line('New age: '||:new.age);
end;
/

--cursor
declare 
cursor emp_cursor is
select name, age from employees where employee_id=9;
v_name employees.name%type;
v_age employees.age%type;
begin
open emp_cursor;
LOOP
fetch emp_cursor into v_name, v_age;
exit when emp_cursor%notfound;
dbms_output.put_line(v_name||v_age);
end loop;
close emp_cursor;
end;
/

