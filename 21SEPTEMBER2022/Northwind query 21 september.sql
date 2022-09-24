--All questions are based on the Northwind database. 

 

--a.    I have also provided a data dictionary (Excel file) that describes each of the tables.

--b.    Write good, clean SQL that answers the following questions. 

--c.     Separate your queries as I have done in the following example. End each query with a semicolon (;) and insert the word "go" between each query. Queries can span multiple lines if required.

--	Select CustomerID from Customers;

--	go

--	Select Count(*) from Employees;

--	go

--	Select max(productID) from Products;

--	Etc.
use Northwind
  

--1.    How many customers do we have in our database?
SELECT COUNT(CustomerID) As 'Total Customers' FROM Customers

--2.    How many of our customer names begin with the letter "b"?
select count(ContactName) as 'Name begin with B' from Customers where ContactName LIKE 'B%'

select* from Customers ORDER BY ContactName

--3.    How many of our customer names contain the letter "s" ?

select count(ContactName) as 'Name CONTAIN with S' from Customers where ContactName LIKE '%S%'

--4.    How many customers do we have in each city?
SELECT CITY, COUNT(CustomerID) FROM Customers group by City

--5.    What are the top three cities where we have our most customers?
SELECT CITY, COUNT(CustomerID) as 'customer count' FROM Customers group by City order by [customer count] desc
--London,Mexico D.F,SAO PAULO

--6.    Who has been our top customer - please list CustomerID, CompanyName, ContactName for the customer that we have sold the most to?
select C.CustomerID ,CompanyName,ContactName from Customers C inner join Orders O on C.CustomerID=O.CustomerID inner join [Order Details] OD 
ON O.OrderID= OD.OrderID
order by Quantity

--7.    Who has been our top customer - please list CustomerID, CompanyName in the year 1997?
select C.CustomerID ,CompanyName,ContactName from Customers C inner join Orders O on C.CustomerID=O.CustomerID inner join [Order Details] OD 
ON O.OrderID= OD.OrderID
where Year(OrderDate)=1997 order by Quantity 
--8.    Name the top 3 countries that we ship our orders to?
select ShipCity,count(Shipcity)as 'order count'from Customers C inner join Orders O on C.CustomerID=O.CustomerID inner join [Order Details] OD 
ON O.OrderID= OD.OrderID
group by (ShipCity)order by count(ShipCity) desc

--9.    Which shipper do we use the most to ship our orders out through?
select ShipName,count(ShipVia) AS 'SHIPMENT'from Customers C inner join Orders O on C.CustomerID=O.CustomerID inner join [Order Details] OD ON O.OrderID= OD.OrderID
group by ShipName order by SHIPMENT desc

--10. List the following employee information (EmployeeID, LastName, FirstName, ManagerLastName, ManagerFirstName)
select E.EmployeeID, E.LastName 'Employee Lastname',E.FirstName 'Employee firstname',M.LastName 'Manager Lastname',
M.FirstName 'Manager firstname' from Employees E , Employees M 
WHERE M.EmployeeID=E.ReportsTo

select* from Employees

--11. What are the last names of all employees who were born in the month of November?
SELECT LastName FROM Employees where Month(BirthDate)=11
--12. List each employee (lastname, firstname, territory) and sort the list by territory and then by employee 
--last name. Remember employees may work for more than one territory.
select TerritoryDescription, LastName,FirstName from Employees E LEFT OUTER JOIN EmployeeTerritories ET 
ON E.EmployeeID=ET.EmployeeID
FULL OUTER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
ORDER BY count(T.TerritoryID), LASTNAME

SELECT* FROM Territories
SELECT* FROM EmployeeTerritories


--13. In terms of sales value, what has been our best selling product of all time?

SELECT top 1 (ProductName) FROM PRODUCTS order by UnitsOnOrder desc

--14. In terms of sales value, and only include products that have at least been sold once, which has been our worst selling product of all time? 
SELECT top 1 (ProductName) FROM PRODUCTS order by UnitsOnOrder 
--15. In terms of sales value, which month has been traditionally best for sales?
select* from products
select* from Suppliers

--16. What is the name of our best sales person?

--17. Product report (productID, ProductName, Supplier Name, Product Category). Order the list by product category.
select ProductID,ProductName from Products group by CategoryID

--18. Produce a count of the employees by each sales region

--19. List the dollar values for sales by region?

--20. What is the average value of a sales order?

--21. List orders (OrderID, OrderDate, Customer Name) where the total order value is greater than the average value of a sales order?

--22. Produce a customer report (must also include those we have not yet done business with) showing CustomerID, Customer name and total sales made to that customer

--23. List all products that need to be re-ordered. Do not include discontinued products in this report.

--24. List all customers that we made a sale to in the year 1996

--25. List all customers that we did not make a sale to in the year 1996

WITh emp_hierarchy AS(select EmployeeID,firstname,lastname,reportsto bossNo, 0 as level1 from Employeeswhere ReportsTo is nullunion all select e.EmployeeID,e.firstname,e.lastname,e.reportsto, level1 + 1 from Employees e, emp_hierarchy  hwhere e.ReportsTo=h.EmployeeID)select * from emp_hierarchy option (MAXRECURSION 4)