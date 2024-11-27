create database infinitetest
use infinitetest
create table book
(
 id int primary key,
 title varchar(20),
 author varchar(20),
 isbn bigint unique,
 published_date date
 )

 create table reviews
 (
 id int references book(id),
 book_id int,
 reviewer_name varchar(20),
 content varchar(20),
 rating int,
 published_date date
 )

 insert into book values(1,'My First SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
 (2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),(3,'My Third SQL book','Cary Flint',523120967812,'2015-10-18 14:05:44')

 insert into reviews values(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11'),(2,2,'John Smith','My second review',5,'2017-10-13 15:12:6'),
 (3,2,'Alice Walker','Another review',1,'2017-10-22 23:47:10')



 select* from book

 select * from reviews

 select * from book where author like '%er'

 select title, author, reviewer_name
from book,reviews
where book.id = reviews.id

select reviewer_name
from reviews
group by reviewer_name
having count(*)>1;

create table customers
(
id int primary key,
name varchar(30),
age int,
address varchar(50),
salary float
)
insert into customers values(1,'Ramesh',32,'Ahmedabad',2000.00),(2,'Khilan',25,'Delhi',1500.00),(3,'Kaushik',23,'kota',2000.00),
(4,'chaitali',25,'mumbai',6500.00),(5,'Hardik',27,'Bhopal',8500.00),(6,'komal',22,'mp',4500.00),(7,'Muffy',24,'Indore',1000.00)

create table orders
(
OID int primary key,
Date date,
customer_id int,
amount bigint,
foreign key(customer_id) references customers(id)
)

insert into orders values(102,'2009-10-08 00:00:00',3,3000),(100,'2009-10-08 00:00:00',3,1500),(101,'2009-11-20 00:00:00',2,1560),
(103,'2008-05-20 00:00:00',4,2060)
select date,count(*) as totalcustomers from orders  group by date
select * from customers

select *from orders



select name from customers 
where address like '%o%'
and address in(
select address from customers
group by address
having COUNT(*)>1
);


create table employee
(
ids int primary key,
names varchar(30),
ages int,
addresss varchar(50),
salarys float
)
insert into employee values(1,'Ramesh',32,'Ahmedabad',2000.00),(2,'Khilan',25,'Delhi',1500.00),(3,'Kaushik',23,'kota',2000.00),
(4,'chaitali',25,'mumbai',6500.00),(5,'Hardik',27,'Bhopal',8500.00),(6,'komal',22,'mp',null),(7,'Muffy',24,'Indore',null)



select Lower(names) as empname  from employee where salarys is null


create table student_details
(
  registerno int primary key,
  name varchar(20),
  age int,
  qualification varchar(20),
  mobile_no bigint,
  Mailid varchar(50),
  location varchar(20),
  gender varchar(10)
  )

  insert into student_details values(2,'sai',22,'b.e',9952836777,'sai@gmail.com','chennai','m'),
  (3,'Kumar',20,'bsc',7890125648,'kumar@gmail.com','madurai','m'),
 ( 4,'selvi',22,'b.tech',890456732,'selvi@gmail.com','selam','f'),
 (5,'Nisha',25,'m.e',7834672310,'nisha@gmail.com','thenai','f'),
 (6,'saisaran',21,'b.a',7890345678,'saisaran@gmail.com','madurai','f'),
 (7,'Tom',23,'bca',8901234675,'tom@gmail.com','pune','m')

 select gender,count(*) from student_details
group by gender

