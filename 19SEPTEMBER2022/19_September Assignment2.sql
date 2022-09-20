Use Library

--Member
create table Member(
Member_Id int Not null Primary key,
Member_Name varchar(25),
Acc_Open_Date Date,
Max_Books_Allowed int,
Penalty_Amount int)

--Book
create table Book(
Book_No int NOT NULL PRIMARY KEY,
Book_Name varchar(30),
Author varchar(30),
Cost int,
Category varchar(10)
)

--Issue
create table Issue(
Lib_Issue_Id int NOT NULL Primary Key,
Book_No int,
Member_Id int,
Issue_Date Date,
Return_Date Date
)

Alter table Issue
Add Foreign key(Book_No) references Book(Book_No);

Alter table Issue
Add Foreign key(Member_Id) references Member(Member_Id);

select *
from INFORMATION_SCHEMA.TABLE_CONSTRAINTS
where CONSTRAINT_TYPE='FOREIGN KEY';

