create table Customer(
custid int NOT NULL PRIMARY KEY,
custname varchar(25),
city varchar(20),
statename varchar(20))

create table Products(
prodid int NOT NULL PRIMARY KEY,
prodname varchar(20),
unitprice int,
unitofmeasurement int,
qtyinstock int)

--Create a table sales_header
--invno,invdate,invamt,disPercent
create table Sales_header(
invno int NOT NULL PRIMARY KEY,
invdate Date,
invamt int,
dispercent int )
-- create a table sales_detail
--invno,custid,prodid,qtysold
create table Sales_detail(
invno int,
custid int,
prodid int,
qtysold int NOT NULL Primary key
)
alter table Sales_detail
Add Foreign key (invno) references Sales_header(invno);

alter table Sales_detail
Add Foreign key (custid) references Customer(custid);

alter table Sales_detail
Add Foreign key (prodid) references Products(prodid);

alter table Sales_detail
Drop constraint [PK__Sales_de__D27685223FD6933B];
alter table Sales_detail
DROP column qtysold;

alter table Sales_detail
add qty int;

--rename using ssms options
ALTER TABLE Sales_detail
alter column Quantity int NOT NULL

ALTER TABLE Sales_detail
ADD CONSTRAINT qty_pk 
PRIMARY KEY (Quantity);

