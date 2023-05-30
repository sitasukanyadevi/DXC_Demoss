Create Database Manipulation

use Manipulation

Create Table Details
(
Cust_id int,
Cust_Email varchar(20),
Cust_Name varchar(30),
Cust_Age int,
Cust_City varchar(20)
)

--Inserting

Insert into Details values (1,'x@gmail.com', 'x', 29,'Vizag')

Insert into Details (Cust_Id, Cust_City, Cust_Email, Cust_Name, Cust_Age) values (2,'AP', 'y@gmail.com', 'y', 30)


Insert into Details (Cust_Id, Cust_Name, Cust_Email, Cust_Age) values (3, 'z', 'z@gmail.com', 18)


Insert into Details values (4,'A@gmail.com','A', 27,'Warangal'),(5,'b@gmail.com', 'b', 25, 'TN')

select * from Details

-- Modifying 

Update Details set Cust_city='Kkd' where Cust_Id=3

Update Details set Cust_city='Hyd', Cust_Email='abc@gmail.com' where Cust_Id=5

-- Delete row from a table

Delete from Details where Cust_Id=3

Select * from Details