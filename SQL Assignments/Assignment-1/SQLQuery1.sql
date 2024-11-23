create database infiniteDb
use infiniteDb

create table Clients
(
Client_ID bigint primary key,
Cname VARCHAR(40) Not null,
Address VARCHAR(30),
Email VARCHAR(30) unique,
Phone bigint,
Business VARCHAR(20) Not null
)

insert into Clients values(1001 ,'ACME Utilities','Noida','contact@acmeutil.com',9567880032, 'Manufacturing'),(1002,'Trackon','Mumbai','consult@trackon.com',8734210090,'Consultant'),(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),(1004,'Lawful Corp','Chennai','justice@lawful.com', 9210342219 ,'Professional')
Select * from Clients

Create table Departments
(
Deptno int primary key,
Dname Varchar(15) Not null,
Loc VARCHAR(20)
)
insert into Departments values(10,'Design','Pune'),(20,'Development','Pune'),(30,'Testing','Mumbai'),(40,'Document','Mumbai')
select * from Departments
create table Employees
(
Empno bigint primary key,
Empname VARCHAR(20) Not null,
Job VARCHAR(15),
Salary bigint,
Deptno int references Departments(Deptno)
)
insert into Employees values(7001,'Sandeep',' Analyst', 25000, 10),(7002,'Rajesh',' Designer', 30000,10),(7003,'Madhav','Developer', 40000,20),(7004,' Manoj','Developer', 40000,20),(7005,' Abhay',' Designer', 35000,10),(7006,' Uma',' Tester', 30000,30),(7007,' Gita',' Tech.Writer', 30000,40),(7008,' Priya',' Tester', 35000,30),(7009,' Nutan',' Developer', 45000,20),(7010,' Smita',' Analyst', 20000,10),(7011,' Anand',' Project Mgr', 65000,10)
alter table Employees
add constraint chksal check(Salary>0)
select * from Employees

create table Projects
(
Project_ID bigint primary key,
Descr VARCHAR(20) Not null,
Start_Date DATE ,
Planned_End_Date DATE,
Actual_End_Date DATE,
Budget bigint,
Client_ID bigint references Clients(Client_ID)
)
insert into Projects values(401,'Inventory','2011-04-01','2011-10-01',null,150000,1001),(402,'Accounting','2011-08-01','2011-01-01',null,500000,1002),(403,'Payroll','2011-10-01','2011-12-31',null,75000,1003),(404,'Conatct Mgmt','2011-11-01','2011-12-31',null,50000,1004)
alter table Projects
add constraint actenddate check(Actual_End_Date>Planned_End_Date)

alter table Projects
add constraint bud check(Budget>0)
Update Projects set Actual_End_Date='2011-12-31' Where Project_ID=401
select * from Projects

create table EmpProjectTasks
(
Project_ID bigint references Projects(Project_ID),
Empno bigint  references Employees(Empno),
Start_Date DATE,
End_Date DATE,
Task VARCHAR(25) Not null,
Status VARCHAR(15) Not null
constraint composite_key primary key(Project_ID,Empno)
)
insert into EmpProjectTasks values(401,7001,'2011-04-01','2011-04-20','System Analysis','Completed'),(401,7002,'2011-04-21','2011-05-30','Design','Completed'),(401,7003,'2011-06-01','2011-07-15','Coding','Completed'),(401,7004,'2011-07-18','01-Sep-11','Coding','Completed'),(401,7006,'2011-09-03','2011-09-15','Testing','Completed'),(401,7009,'2011-09-18','2011-10-05','Code change','Completed'),(401,7008,'11-10-2011','2011-10-16','Testing','Completed'),(401,7007,'2011-10-06','2011-10-22','Documentation','Completed'),(401,7011,'2011-10-22','2011-10-31','Sign off','Completed'),(402,7010,'2011-08-01','2011-08-20','System Analysis','Completed'),(402,7002,'2011-08-22','2011-10-30','System Design','Completed'),(402,7004,'2011-10-01',null,'Coding','In Progress')

Select * from EmpProjectTasks










