create database assig4
use assig4

-----1)T-SQL Program to find the factorial of a given number-------
begin
declare @number int=7
declare @a int=1
declare @factorial int =1
while @a<=@number
begin
   set @factorial=@factorial*@a
   set @a=@a+1
end
print 'The factotial of the number ' + cast(@number as varchar(10)) +' is '+cast(@factorial as varchar(10))
end

-----2)stored procedure to generate multiplication table that accepts a number and generates up to a given number
create or alter proc multiplication(@number int)
as
begin
declare @i int=1
declare @output int
declare @anothernumber int=5
  while @i<=@anothernumber
  begin
     set @output=@number*@i
     print cast(@number as varchar(10)) +' * ' +cast(@i as varchar(10))+ ' = '+cast(@output as varchar(10))
	 set @i=@i+1
  end
end
 
exec Multiplication 10

----3)function to calculate the status of the student. If student score >=50 then pass, else fail

create table student
(
sid int primary key,
sname varchar(10),
)
create table Marks
(
mid int primary key,
sid int references student(sid),
score int,
)

insert into student values(1,'Jack'),
(2,'Rithvik'),(3,'Jaspreeth'),(4,'Praveen'),(5,'Bisa'),(6,'Suraj')
 
 
insert into Marks values(1,1,23),
(2,6,95),(3,4,98),(4,2,17),(5,3,53),(6,5,13)

create or alter function Student_Score (@score int)
returns varchar(10)
as
begin
declare @result varchar(10)
  if @score>=50
  begin
    set @result='Pass'
  end
  else
  begin
    set @result='Fail'
  end
return @result
end
 
select s.sid,m.mid,s.sname,m.score,dbo.Student_Score(m.score) as 'Result_Status' from student s 
 join Marks m on s.sid=m.sid order by s.sid



