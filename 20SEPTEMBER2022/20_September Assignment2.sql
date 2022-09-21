create database Library
Use Library

--Member
create table Member(
Member_Id numeric(5) Not null Primary key,
Member_Name char(25),
Acc_Open_Date Date,
Max_Books_Allowed numeric(2),
Penalty_Amount numeric(7,2))

--Book
create table Book(
Book_No numeric(6) NOT NULL PRIMARY KEY,
Book_Name varchar(30),
Author char(30),
Cost numeric(7,2),
Category char(10)
)

--Issue
create table Issue(
Lib_Issue_Id numeric(10) NOT NULL Primary Key,
Book_No numeric(6),
Member_Id numeric(5),
Issue_Date Date,
Return_Date Date
)

--Alter table Issue
--Add Foreign key(Book_No) references Book(Book_No);

--Alter table Issue
--Add Foreign key(Member_Id) references Member(Member_Id);

--select *
--from INFORMATION_SCHEMA.TABLE_CONSTRAINTS
--where CONSTRAINT_TYPE='FOREIGN KEY';

EXEC sp_help 'dbo.Book';
EXEC sp_help 'dbo.Issue';
EXEC sp_help 'dbo.Member';

Alter table Issue
Add Comments varchar(100)

Alter table Member
Alter column Member_Name char(30)

Alter table Issue
Add Reference char(30)

Alter table Issue
Drop Column Reference

EXEC sp_rename 'Issue','Lib_Issue';

Insert into Member values(1,'Richa Sharma','2005-12-10',5,50)
Insert into Member values(2,'Garima Sen',GETDATE(),3,NULL)
Insert into Member values(3,'Sheriff',Null,4,79.80)
Insert into Member values(4,'Nazira Begum',GETDATE(),null,56)
Insert into Member values(5,'Garima Sen','2018-06-09',4,50)

Alter table Member
Alter column Member_Name char(20)

Insert into Member values(6,'Nilofar sheriff','2020-10-27',5,110)
Insert into Member values(7,'Asif Zamruth','2020-10-11',110,70.23)

--Msg 8115, Level 16, State 8, Line 68
--Arithmetic overflow error converting int to data type numeric.
--The statement has been terminated.
--this occurs as the limit of max book exceeded

select * into Member101 from Member
select * into Member102 from Member where 1 = 2

Insert into Book values(101,'Let us C','Dennis Ritchie',450,'System')
Insert into Book values(102,'Oracle-complete Ref','Loni',550,'Database')
Insert into Book values(103,'Mastering SQL','Loni',250,'Database')
Insert into Book values(104,'PL SQL-Ref','Scott Urman',750,'Database')

--Insert into Book values(105,'Electronics','David bell',453,'System')AND(106,'Electrical','P.C.Sen',383,'Electrical')

select* into Book101 from Book where 1=2

insert into Book101
select* from Book;

insert into Book values(105,  'National Geographic', 'Adis Scott', 1000,  'Science')

update Book
set Cost=300,Category='Rdbms'
where Book_No=103

exec sp_rename Lib_Issue, Issue

Insert into Issue values(7001,101,1,'2006-12-10',null,'nothing'),(7002,102,2,'2006-12-25',null,'nothing'),(7003,104,1,'2006-01-15',null,'nothing'),(7004,101,1,'2006-06-04',null,'nothing'),
(7005,104,2,'2006-11-15',null,'nothing'),(7006,101,3,'2006-02-18',null,'nothing')


Insert into Issue values(7007,102,2,'2006-12-10',null,'nothing'),(7008,103,1,'2006-12-25',null,'nothing')

Update Issue
set Return_Date= DATEADD(Day,15,Issue_Date)
where Lib_Issue_Id=7004

Update Issue
set Return_Date= DATEADD(Day,15,Issue_Date)
where Lib_Issue_Id=7005


update Member
set Penalty_Amount=100 where Member_Name='Garima Sen'


Delete from Issue where Member_Id=1 and Issue_Date<'2006-12-10' 

delete from Book where Category!='RDBMS'and Category!='Database'

Drop table Member101

Drop table Book101


select* from Book
select* from Member
select* from Member102
select* from Issue


SELECT
  *
FROM
  INFORMATION_SCHEMA.TABLES;
GO


------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------

Insert into Member values(7,'Sheriff','2006-10-27',4,57)

select * from Member where Year(Acc_Open_Date) = 2006

select * from Book where Author = 'Loni' and Cost<600

select * from Issue where Return_Date IS NULL

--4)	Update all the blank return_date with 31-Dec-06 excluding 7005 and 7006

UPDATE ISSUE
set Return_Date='2007-01-30'
where Lib_Issue_Id!=7005 and Lib_Issue_Id!=7006

select* from Issue where Datediff( Day,Issue_Date,Return_Date) >30

--6)	List all the books that have price in range of 500 to 750 and has category as Database.
select* from Book where Cost>500 and Cost<750 and Category='Database' 

--7)	List all the books that belong to any one of the following categories Science, Database, Fiction, Management.

select* from Book where Category='Science' or Category='Database' or Category='Fiction' or Category='Management'

--8)	List all the members in the descending order of Penalty due on them.
select* from Member
order by Penalty_Amount desc

--9)	List all the books in ascending order of category and descending order of price.
select* from Book
order by Category,Cost desc

--10)	List all the books that contain word SQL in the name of the book.
select* from Book
where Book_Name LIKE '%SQL%'

--11)	List all the members whose name starts with R or G and contains letter I in it.
SELECT* FROM Member
where Member_Name Like 'R%' or Member_Name LIKE '%g' or Member_Name Like '%i%'

--12)	List the entire book name in Init cap and author in upper case in the descending order of the book name.
--select Initcap (Book_Name),Upper(Author) from Book
--order by Book_Name desc

--13)	Show the data in the following format :

--Book No		--------------------------------			NAME

--101		is written by  					Denis Ritchie
--102		is written by  					Loni

Select CONCAT( Book_No,' ','is written by',' ' ,Author) as 'Book id and author' from Book 

--14)	List the Issue Details for all the books issue by member 101  
--with Issue_date and Return Date in following format. ‘Monday, 
--July, 10, 2006’.

--select ToChar Issue_Date, Return_date, Member_Id from Issue
--where Member_Id=1
--15)	List the data in the book table with category data displayed as  
--	D for Database, S for Science, R for RDBMS and O for all the  
--others.

--select category,decode(category,'database','D','rdbms','R','science','S','others','O') as types from Book




--19)	Find the details of the member of the Library in the order of their 
--joining the library.

select* from Member order by Acc_Open_Date

--20)	Display the count of total no of books issued to Member 101.
select count(Book_No) as 'Total Book count' from Issue where Member_Id=1 


--21)	Display the total penalty due for all the members.
select sum(Penalty_Amount) as 'Total Penalty Amount' from Member

--22)	Find the total cost of all the books that come under category 
--Database.
select sum(Cost) as 'total cost of database books' from Book where Category='Database'

--23)	Find the cheapest book price in the library.
select min(cost) as 'Cheapest book' from Book 

--24)	Find the date on which the very first book was issued in the
--library.
select min(Issue_Date) as 'First Book issued on' from Issue

--25)	Find the date on which most recent the book was issued.
select max(Issue_Date) as 'Latest Book issued on' from Issue

--26)	Find the average price of book in Database category.

select AVG(cost) as 'Average cost of Database Books' from Book where Category='Database'

--first
--13,19
--second
--12,14,15,16

select* from Book
select* from Member
select* from Member102
select* from Issue