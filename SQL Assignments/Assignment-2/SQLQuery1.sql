Create database infinite
use infinite

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
--1.all employees whose name begins with 'A'
select * from EMP where ENAME like 'A%'

--2.all those employees who don't have a manager
select *from EMP where MGR_ID is null

--3. employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ENAME,EMPNO,SAL from EMP
where SAL between 1200 and 1400

--4.all the employees in the RESEARCH department a 10% pay rise.
select D.DNAME,E.EMPNO,E.ENAME,E.JOB,E.SAL,E.MGR_ID,E.HIREDATE,E.COMM,(SAL+(SAL*0.1)) 'UPADATED SAL'
from DEPT D inner join EMP E on D.DNAME='RESEARCH'

--5.number of CLERKS employed
select COUNT(JOB) as 'NUMBER OF CLERKS' from EMP where JOB='CLERK'

--6.average salary for each job type and the number of people employed in each job
select JOB,avg(SAL) [AVERAGE SALARY],count(*) [no of people] from EMP group by JOB 

--7.employees with the lowest and highest salary. 
select  max(SAL) 'Maximum Salary' , min(SAL) 'Minimum Salary' from EMP

--8.full details of departments that don't have any employees. 
select * from DEPT where DEPTNO not in(select  DEPTNO from EMP)

--9.names and salaries of all the analysts earning more than 1200 who are based in department 20.
select ENAME, SAL
from EMP
where JOB= 'ANALYST' and SAL>1200 and DEPTNO=20 
order by ENAME asc

--10.name and number together with the total salary paid to employees in that department. 
select D.DNAME,D.DEPTNO,SUM(E.SAL) 'total salary paid to employees'
from DEPT D left join EMP E on D.DEPTNO=E.DEPTNO group by D.DEPTNO,DNAME

--11.salary of both MILLER and SMITH.
select ENAME,SAL from EMP where (ENAME= 'MILLER') OR (ENAME='SMITH')

--12.names of the employees whose name begin with ‘A’ or ‘M’
select ENAME from EMP where ENAME like 'A%' or ENAME like  'M%'

--13.yearly salary of SMITH.
select ENAME,SAL,(SAL*12) as 'yearly salary' from EMP where ENAME='SMITH'

--14.name and salary for all employees whose salary is not in the range of 1500 and 2850.
select ENAME,SAL from EMP where SAL not between 1500 and 2850 
             
--15.all managers who have more than 2 employees reporting to them
select MGR_ID,count(*) from EMP group by MGR_ID having count(*)>2