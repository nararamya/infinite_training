create database assesment3
use assesment3

---1)------------------------------------------
create table course_details
(
C_id varchar(20) ,
C_Name varchar(20),
Started_date Datetime,
End_date Datetime,
FEE float,
);
drop table course_details

insert into course_details values('DN003','Dot Net','2018-02-01','2018-02-28',15000),('DV004','Data Visualization','2018-03-01','2018-04-15',15000),
('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),('JC001','CoreJava','2018-01-02','2018-01-12',3000)


create or alter function Course_Duration (@startdate datetime,@enddate datetime)
returns int
as
begin
declare @duration int 
select @duration=DATEDIFF(DAY,Started_date,End_date) from course_details
return @duration
end
 
select C_id,C_Name,assesment3.dbo.Course_Duration(Started_date,End_date) as Duration,Fee from Course_Details


---2)---------------------------------------

create or alter trigger tgrdetails
on course_details
for insert
as
begin
insert into course_details(C_Name,Started_date)
select C_Name,Started_date from inserted

end

insert into course_details values ('avcd0','c++','2018-03-12','2024-08-7',2000)

select * from course_details



 


-------3)-----------------------------------------------
CREATE TABLE Products_details(
ProductID INT IDENTITY(1,1),
ProductName VARCHAR(20),
Price INT,
DiscountedPrice as (Price*0.10)
)
 
CREATE PROCEDURE ProdInsertion @ProductName VARCHAR(25), 
@Price INT, @ProductID INT OUTPUT as
BEGIN
INSERT INTO Products_details(ProductName, Price) VALUES(@ProductName,@Price)
SET @ProductID = SCOPE_IDENTITY()
END
 
DECLARE @newProductID INT
EXEC ProdInsertion 
@ProductName = 'cake',
@Price = 100,
@ProductID = @newProductID OUTPUT
 
SELECT @newProductID as ProductID
SELECT * FROM Products_details









