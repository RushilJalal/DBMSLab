create table student(
    regno varchar(20),
    name varchar(50),
    major varchar(20),
    bdate date,
    primary key(regno));

create table course(
    course# int,
    cname varchar(30),
    dept varchar(30),
    primary key(course#));

create table enroll(
  regno varchar(20),
  course# int,
  sem int,
  book_isbn int,
  foreign key(regno) references student,
  foreign key(course#) references course,
  foreign key(book_isbn) references text);

create table book_adoption(
    course# int,
    sem int,
    book_isbn int,
    foreign key(course#) references course,
    foreign key(book_isbn) references text);

create table text(
    book_isbn int,
    booktitle varchar(50),
    publisher varchar(50),
    author varchar(50),
    primary key(book_isbn));

insert into student values(1, 'Rohan', 'CCE', To_Date('2024/03/01', 'yyyy/mm/dd'));
insert into student values(2, 'Suresh', 'IT', To_Date('2024/02/01', 'yyyy/mm/dd'));
insert into student values(3, 'Ben', 'CSE', To_Date('2024/01/03', 'yyyy/mm/dd'));
insert into student values(4, 'Peter', 'CCE', To_Date('2023/11/11', 'yyyy/mm/dd'));
insert into student values(5, 'Mary', 'Mechanical', To_Date('2023/12/12', 'yyyy/mm/dd'));
insert into student values(6, 'Rushil', 'CCE', To_Date('2004/07/21', 'yyyy/mm/dd'));


insert into course values(234, 'Python', 'Biotech');
insert into course values(456, 'DAA', 'ICT');
insert into course values(435435, 'SDT', 'ICT');
insert into course values(45345, 'DBMS', 'DSC');
insert into course values(34534, 'OS', 'ICT');

insert into text values(1234, 'Book1', 'A', 'A1');
insert into text values(1235, 'Book2', 'B', 'A2');
insert into text values(1236, 'Book3', 'C', 'A3');
insert into text values(1237, 'Book4', 'D', 'A4');
insert into text values(1238, 'Book5', 'E', 'A5');

insert into enroll values(1, 234, 1, 1234);
insert into enroll values(2, 456, 2, 1235);
insert into enroll values(3, 435435, 3, 1236);
insert into enroll values(4, 45345, 3, 1237);

insert into book_adoption values(234, 1, 1234);
insert into book_adoption values(456, 2, 1235);
insert into book_adoption values(435435, 3, 1236);
insert into book_adoption values(45345, 4, 1237);
insert into book_adoption values(34534, 5, 1238);

-- a)
select cname, course#
from course
where course# in (select course#
                    from book_adoption
                    group by course#
                    having count(*) > 1);

-- c)
select name
from student full outer join enroll using (regno) full outer join course using (course#);
where dept in 
(select dept
from course
group by dept
having count(*) > 1);

-- d)
select *
    from student
    where regno not in (select regno
                        from enroll);

-- q6.
select booktitle from text 
where book_isbn in (select book_isbn from enroll 
where book_isbn in(select book_isbn from book_adoption));

-- q8.
select * 
from student 
where regno in 
(select regno from student natural join enroll group by regno 
having count(*)=(select max(count(*)) from student natural join enroll group by regno));

-- q9. 
with cnt(publisher, no) as (select publisher, count(*)  from text group by publisher)
    select publisher, no as count from cnt;