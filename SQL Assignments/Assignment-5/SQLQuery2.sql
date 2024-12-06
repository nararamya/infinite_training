
use infinite
select * from EMP

--1)complete payslip of a given employee

create or alter proc update_sal(@eno int)
as
 begin
 declare @sal float,@hra float,@da float,@pf float,@it float,@deductions float,@gross_sal float,@net_sal float
 select @sal=sal from EMP where EMPNO=@eno

     set  @hra=@sal*0.10;

     set @da=@sal*0.20;
 
       set @pf=@sal*0.08;

	   set @it=@sal*0.05;

	   set @deductions=@pf+@it

	   set @gross_sal=@sal+@hra+@da

	   set @net_sal=@gross_sal-@deductions

	   print 'HRA:' + cast(@hra as varchar(10)) 
	   print 'DA:' + cast(@da as varchar(10)) 
	   print 'PF:' + cast(@pf as varchar(10)) 
	   print 'IT:' + cast(@it as varchar(10)) 
	   print 'Deductions:' + cast(@deductions as varchar(10)) 
	   print 'Gross Salary:' + cast(@gross_sal as varchar(10)) 
	   print 'Net Salary:' + cast(@net_sal as varchar(10)) 
	   
  end;

  update_sal 7788

  --2)a trigger to restrict data manipulation on EMP table during General holidays
  create table holiday
  (
  holiday_date date primary key,
  Holiday_name varchar(20),
  );

  insert into holiday values('2024-12-06','Republic Day'), ('2024-08-15','Independence Day'),('2024-10-02','Gandhi Jayanti'),( '2024-10-03','Diwali')
  select * from holiday
create or alter trigger trg_emp_data
on Emp
for insert,update,delete
as
begin
  declare @holiday_name varchar(20)
  select @holiday_name=Holiday_name from Holiday where holiday_date=cast(Getdate() as date)
  if @holiday_name is not null
  begin
      raiserror('you cannot manipulate data due to %s',16,1,@holiday_name)
  rollback transaction
   end
end

insert into emp values(7377,'ramya','manger',7499,'1981-03-30',5000,1000,10)
delete from emp where EMPNO=7521
update emp set sal=4000 where EMPNO=7654

