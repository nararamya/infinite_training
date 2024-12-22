create database prj
use prj

CREATE TABLE Trains (
    TrainNumber INT PRIMARY KEY ,
    TrainName VARCHAR(100),
    Source VARCHAR(100),
    Destination VARCHAR(100),
	TotalBerths INT,
    AvailableBerths INT,
	travel_date Date,
	Price INT,
    IsActive BIT default 1
);
drop table Trains

create table BookTickets(
   Booking_ID INT primary key,
   TrainNumber INT,
   Booking_Date Date,
   Source VARCHAR(20),
   Destination VARCHAR(20),
   number_of_tickets INT,
   Train_Class VARCHAR(10),
   TotalPrice float,
   foreign key (TrainNumber) references Trains(TrainNumber)
);

 drop table BookTickets

 create table Users(
 Booking_ID INT primary key,
 TrainNumber INT,
 Users_Name VARCHAR(20),
 Age INT,
 Gender VARCHAR(20),
 number_of_tickets INT,
 Class VARCHAR(20),
 TotalPrice float,
 foreign key (Booking_ID) references BookTickets(Booking_ID)
 );
 drop table Customers
 ---------------------------------------------------------------------------------------------

 CREATE OR ALTER PROCEDURE AddTrain
    @TrainNum Varchar(50),
    @TrainName VARCHAR(50),
    @Source VARCHAR(50),
    @Destination VARCHAR(50),
	@TotalBerths INT,
	@AvailableBerths INT,
	@travel_date Date,
	@price int,
	@message VARCHAR(100) out
	
AS
BEGIN
 IF @travel_date >= GETDATE() 
    BEGIN
	IF @TotalBerths>=@AvailableBerths
	BEGIN
    INSERT INTO Trains (TrainNumber ,TrainName, Source, Destination,TotalBerths, AvailableBerths,Travel_Date,Price)
    VALUES (@TrainNum,@TrainName, @Source, @Destination,@TotalBerths,@AvailableBerths,@travel_date,@price)
	set @Message ='Train Added Successfully';
	END
    ELSE
    BEGIN
	 SET @Message='Total berths is less than availabel berths';
	 END
        END
		ELSE
		BEGIN
        set @Message='Date must be greater than or equal to current date.';
    END
END;

--------------------------------------------------------------------------------------------
 
CREATE OR ALTER PROCEDURE DeleteTrain
    @TrainNum INT,
	@message VARCHAR(100) out

AS
BEGIN
DECLARE @train_no int,@active bit
select @train_no= TrainNumber,@active=IsActive from Trains where @TrainNum=TrainNumber 
IF @train_no=@TrainNum and @active=1
 BEGIN
    UPDATE Trains
    SET IsActive = 0
    WHERE TrainNumber = @TrainNum;
	set @Message ='Train Deleted Successfully';
END
ELSE
BEGIN
 SET @Message = 'Train number does not exist.';
 END
END;

 
 -----------------------------------------------------------------------------------------------
 
CREATE OR ALTER PROCEDURE ModifyTrain
    @TrainNum INT,
    @TrainName VARCHAR(100),
    @Source VARCHAR(100),
    @Destination VARCHAR(100),
	@TotalBerths INT,
	@AvailableBerths INT,
	@travel_date Date,
	@price INT,
	@Message VARCHAR(100) out

AS
 BEGIN
 DECLARE @train_no int,@active bit
select @train_no= TrainNumber,@active=IsActive from Trains where @TrainNum=TrainNumber 

  IF @travel_date >= GETDATE() 
  BEGIN
  IF  @TotalBerths>=@AvailableBerths
  BEGIN
   IF @train_no=@TrainNum and @active=1
   BEGIN
    UPDATE Trains
    SET TrainName = @TrainName,
        Source = @Source,
        Destination = @Destination,
		TotalBerths=@TotalBerths,
        AvailableBerths = @AvailableBerths,
		travel_date=@travel_date,
		Price=@price
    WHERE TrainNumber = @TrainNum;
	set @Message ='Train Modified Successfully';
	END
	ELSE
	BEGIN
	  SET @Message = 'Train number does not exist.';
	 END
	 END
	 ELSE 
	 BEGIN
	 SET @Message='Total berths is less than available berths';
	 END
	 END
	 ELSE
    BEGIN
        SET @Message = 'Date must be greater than or equal to current date.';
    END
END;
 --------------------------------------------------------------------------------------
 CREATE OR ALTER PROCEDURE CheckTrain
    @booking_date DATE,
    @source VARCHAR(100),
    @destination VARCHAR(100),
    @number_of_tickets INT,
	@Message VARCHAR(100) output

AS 
BEGIN
 DECLARE @train_num int,@price int, @available INT,@total_price float,@active bit
	IF @booking_date >= GETDATE() 
	BEGIN
    select @available=  AvailableBerths,@active=IsActive from Trains where Source = @source and Destination=@destination and travel_date =@booking_date;
	IF @available>=@number_of_tickets and  @active=1 
	BEGIN
	 select @train_num=TrainNumber,@price=Price From Trains Where Source = @source and Destination=@destination and travel_date =@booking_date;
	  set @total_price=@number_of_tickets*@price;
		set @Message=CONCAT('Train number available is:',@train_num,',','','Total price is:',@total_price);
    END
	ELSE
	BEGIN
	   set @Message='Trains or tickets are not available';
	END
	END
	ELSE 
	BEGIN
	   set @Message='Date must be greater than or equal to current date';
	END
	END
  
-------------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE BookTicket

	@train_num INT,
    @number_of_tickets INT,
	@class VARCHAR(100),
	@name VARCHAR(10),
	@age INT,
	@gender VARCHAR(10),
	@Message VARCHAR(100) out

As
BEGIN
    DECLARE @booking_id int, @booking_date DATE, @source VARCHAR(100), @destination VARCHAR(100), @price INT,@total_price float,@active bit, @available INT;
    select @price=Price,@booking_date=travel_date,@source=Source,@destination=Destination,@available=AvailableBerths,@active=IsActive from Trains where TrainNumber= @train_num;
	IF @active=1
	BEGIN
	IF @available>=@number_of_tickets
	BEGIN
     set @booking_id=RAND()*10000;
	 set @total_price=@number_of_tickets*@price;
	
     insert into BookTickets values (@booking_id,@train_num,@booking_date, @source,@destination,@number_of_tickets,@class,@total_price);
	 update Trains set AvailableBerths = AvailableBerths - @number_of_tickets
        where TrainNumber= @train_num ;

		Insert into Users values (@booking_id,@train_num,@name,@age,@gender,@number_of_tickets,@class,@total_price);

		set @Message=CONCAT('Booking confirmed ! Your booking ID is :',@booking_id);
	END
	ELSE 
	BEGIN
	set @Message='Tickets are not available';
	END
	END
    ELSE
	BEGIN
	set @Message='Entered Wrong Train Number';
	END
	END
----------------------------------------------------------------------------------------------


create or alter procedure Cancel_Tickets
@booking_id int,
@Message VARCHAR(100) out
AS
BEGIN
    declare @train_num int, @tckts int,@book_tckt int;
	select @book_tckt=Booking_ID from BookTickets where Booking_ID=@booking_id
	IF @book_tckt=@booking_id
	BEGIN
    select @train_num = TrainNumber, @tckts = number_of_tickets from BookTickets where Booking_ID = @booking_id;
	delete from Users where Booking_ID=@booking_id;
    delete from BookTickets where Booking_ID = @booking_id;
    update Trains set AvailableBerths = AvailableBerths + @tckts where TrainNumber = @train_num;
	set @Message='Bookings Cancelled!';
END
ELSE
BEGIN
     set @Message='Booking ID entered invalid!';
	 END
 END

--------------------------------------------------------------------------------------------------

create or alter proc ShowTrains
as
begin
     select * from Trains where IsActive=1;
end
 
 ---------------------------------------------------------------------------------------------------
 
create or alter proc ShowBookings
as
begin
     select * from BookTickets 
end

----------------------------------------------------------------------------------------------------
 select * from Trains

 select * from BookTickets

 select * from Users





