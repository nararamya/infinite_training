create database assignment3
use assignment3


Create table DEPT
  (
  DEPTNO int primary key,
  DNAME  varchar(10),
  LOC varchar(10)
  )

  insert into  DEPT values(10, 'ACCOUNTING',' NEW YORK'),(20,'RESEARCH','DALLAS'),(30,'SALES','CHICAGO'),(40 ,'OPERATIONS','BOSTON')

  select *from  DEPT
Create table EMP
(
  EMPNO int,
  ENAME varchar(10),
  JOB varchar(10),
  MGR_ID int,
  HIREDATE date,
  SAL int,
  COMM int,
  DEPTNO int references DEPT(DEPTNO)
  )

 insert into EMP values(7369,'SMITH', 'CLERK',7902,'17-DEC-80',800,null,20),(7499,'ALLEN','SALESMAN',7698 ,'20-FEB-81 ',1600,300,30),
(7521,'WARD','SALESMAN' ,7698 ,'22-FEB-81',1250 ,500,30),(7566,'JONES','MANAGER' ,7839 ,'02-APR-81',2975 ,null,20),
(7654,'MARTIN','SALESMAN',7698 ,'28-SEP-81',1250,1400,30),(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER' ,7839,'09-JUN-81', 2450,null,10),(7788,'SCOTT','ANALYST',7566 ,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),(7844,'TURNER','SALESMAN', 7698 ,'08-SEP-81',1500,0,30),
(7876 ,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),(7934,'MILLER','CLERK',7782,'23-JAN-82', 1300,null,10)
select * from EMP


----1)Retrieve a list of MANAGERS. 
 select distinct e2.ENAME as 'MANAGERS' from EMP e1 join EMP e2 on e1.MGR_ID=e2.EMPNO

---2) The names and salaries of all employees earning more than 1000 per month
select Ename,sal from EMP where SAL>1000

--3)the names and salaries of all employees except JAMES. 
select Ename,sal from emp where ename!='James'

--4)the details of employees whose names begin with ‘S’
 select * from emp where ENAME like 's%'

 --5)the names of all employees that have ‘A’ anywhere in their name
 select ENAME from emp where ENAME like '%a%'

 --6)the names of all employees that have ‘L’ as their third character in their name. 
 select ENAME from emp where ENAME like '__L%'

 --7) daily salary of JONES
 select (SAL/30) as Dailysalary from Emp where ENAME='JONES'

 --8)total monthly salary of all employees. 
 select SUM(SAL) as  total_salary from emp 

 --9)average annual salary 
 select avg(SAL*12) as average_annual_salary from emp

 --10)the name, job, salary, department number of all employees except SALESMAN from department number 30. 
 select Ename,job,sal,deptno from emp where empno not in(select EMPNO where job = 'SALESMAN' and DEPTNO=30)

--11) unique departments of the EMP table. 
 select distinct DNAME from DEPT,EMP where DEPT.DEPTNO=EMP.DEPTNO 

--12)name and salary of employees who earn more than 1500 and are in department 10 or 30.
  select ENAME as 'Employee ',SAL as 'Monthly Salary' from EMP where SAL>1500 and DEPTNO in (10,30)

--13)name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ENAME,JOB,SAL from EMP where JOB = 'MANAGER' or JOB= 'ANALYST' and SAL not in(1000,3000,5000)

--14) name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select ENAME,SAL,COMM from EMP where COMM >(SAL+SAL*0.1)

--15)name of all employees who have two Ls in their name and are in department 30 or their manager is 7782. 
select ENAME from EMP where ENAME like '%l%l%' and DEPTNO=30 or MGR_ID=7782

--16)names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees. 
 select count(ENAME) [total number of employees] from EMP 
 where DATEDIFF(year,Hiredate,getdate())>30 and DATEDIFF(year,Hiredate,getdate())<40
 select ENAME from EMP where (DATEDIFF(year,Hiredate,getdate())>30 and DATEDIFF(year,Hiredate,getdate())<40)

 --17)names of departments in ascending order and their employees in descending order. 
 select DNAME,ENAME from DEPT,EMP where DEPT.DEPTNO=EMP.DEPTNO order by DNAME asc,ENAME desc

 --18)experience of MILLER. 
 select DATEDIFF(year,Hiredate,getdate()) as 'experience of MILLER' from EMP where ENAME='MILLER'
