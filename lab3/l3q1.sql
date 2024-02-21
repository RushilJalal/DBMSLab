-- **SETTINGS
-- set pagesize 200
-- set linesize 500
-- **

--DDL
create table Person(
    driver_id# varchar(30),
    name varchar(50),
    address varchar(100),
    primary key(driver_id#));

create table car(
    regno varchar(20),
    model varchar(30),
    year int,
    primary key(regno));

create table accident(
    report_number int,
    accd_date date,
    location varchar(50),
    primary key(report_number));

create table owns(
    driver_id# varchar(30),
    regno varchar(20),
    primary key(driver_id#, regno));

create table participated(
    driver_id# varchar(30),
    regno varchar(20),
    report_number int,
    damage_amount int,
    primary key(driver_id#, regno, report_number),
    foreign key (driver_id#) references person,
    foreign key (regno) references car,
    foreign key (report_number) references accident);

--DDL

insert into person values('1','John','Mumbai');
insert into person values('2','Mary','Pune');
insert into person values('3','Sasha','New York');
insert into person values('4','Anaadhi','Delhi');
insert into person values('5','Mongia','Delhi');

insert into car values('A', 'model1',2000);
insert into car values('B', 'model2',2001);
insert into car values('C', 'model3', 2002);
insert into car values('D', 'model4', 2003);
insert into car values('E', 'model5', 2004);
insert into car values('F', 'model1', 2007);

insert into accident values(12, To_Date('2024/01/01', 'yyyy/mm/dd'), 'Ghaziabad');
insert into accident values(13, To_Date('2024/02/01', 'yyyy/mm/dd'), 'Ghaziabad');
insert into accident values(14, To_Date('2024/03/01', 'yyyy/mm/dd'), 'Ghaziabad');
insert into accident values(15, To_Date('2024/04/01', 'yyyy/mm/dd'), 'Ghaziabad');
insert into accident values(16, To_Date('2024/05/01', 'yyyy/mm/dd'), 'Ghaziabad');
insert into accident values(17, To_Date('2008/05/01', 'yyyy/mm/dd'), 'Lucknow');

insert into owns values('1','A');
insert into owns values('2','B');
insert into owns values('3','C');
insert into owns values('4','D');
insert into owns values('5','E');
insert into owns values('6','F');

insert into participated values('1', 'A', 12, 10000);
insert into participated values('2', 'B', 13, 20000);
insert into participated values('3', 'C', 14, 3000);
insert into participated values('4', 'D', 15, 50000);
insert into participated values('5', 'E', 16, 990000);
insert into participated values('6', 'F', 17, 3469);

--3
update participated set damage_amount = 25000 where regno = 'A' and report_number = 12;

--4
-- first delete from participated since it contains foreign keys from accident
delete from participated where report_number in (select report_number from accident where extract(year from accd_date)=2024);
delete from accident where extract(year from accd_date)=2024;

--5
alter table person
add phone_number varchar(10);

alter table person
drop column name;

--6
alter table person
add constraint check_id check(driver_id# is not null);



