use assignment3

----1)------------
select DATENAME(WEEKDAY,
'2001-04-03') as Birthday_dayofweek;
 

 ----2)-------------
select datediff(Day,'2001-06-07',getdate()) as Age_in_Days

------3)------------
select * from EMP
where year(getdate()) - year(HIREDATE) > 5
 AND month(HIREDATE) = month(getdate());



-----4)-----------
 
CREATE TABLE Employee(
    empno INT PRIMARY KEY,
    ename VARCHAR(50),
    sal DECIMAL(10),
    doj DATE
);

 
BEGIN TRANSACTION;
 
-- a) Insert 3 rows
INSERT INTO Employee (empno, ename, sal, doj) VALUES (1, 'RAMYA', 80000, '2022-01-02');
INSERT INTO Employee(empno, ename, sal, doj) VALUES (2, 'KRISHNA', 50000, '2020-03-15');
INSERT INTO Employee(empno, ename, sal, doj) VALUES (3, 'RAMA', 60000, '2018-05-22');
 
 select * from Employee
-- b) Update the second row sal with 15% increment
UPDATE Employee
SET sal = sal*1.15
WHERE empno = 2;
 
-- c) Delete the first row
DELETE FROM Employee
WHERE empno = 1;
 
 -- d. Recall the deleted row without losing increment of second row
DECLARE @deleted_empno INT, @deleted_ename VARCHAR(100), @deleted_sal DECIMAL(10), @deleted_doj DATE;
 
SELECT @deleted_empno = empno, @deleted_ename = ename, @deleted_sal = sal, @deleted_doj = doj
FROM (SELECT empno, ename, sal, doj FROM (VALUES (1, 'RAMYA', 80000, '2022-01-02')) AS A(empno, ename, sal, doj)) AS DeletedRow;
 

INSERT INTO Employee (empno, ename, sal, doj) VALUES (@deleted_empno, @deleted_ename, @deleted_sal, @deleted_doj);
 
COMMIT TRANSACTION;

-----5)------------
create or alter  Function Calculated_Bonus                
(
  @deptno int,
  @sal decimal(10,2)
  )
  returns decimal(10,2)
  as 
  begin
  declare @Bonus float;
  if  @deptno=10
     set  @bonus=@sal*0.15;
  else if @deptno=20
     set @bonus=@sal*0.20;
  else
       set @bonus=@sal*0.05;
  return @bonus;
  end;
 

select EmpNo, EName, dbo.Calculated_Bonus(deptno,Sal) as BONUS from Emp
select * from DEPT
------6)----------


 

create or alter procedure  Sal_update_in_Sales_dept             
  as
  begin
    update emp
    set sal=sal+500
	where deptno=(select deptno from dept where dname='SALES') and sal<1500
  end
 
  Exec Sal_update_in_Sales_dept
  select *from emp