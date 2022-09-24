
use Library

-- Concept: 	Group by, Having, Use of Aggregate functions.
--Set Operators
--Joins


--Task / Problems:

--1)	List the various categories and count of books in each category.
select Category,count(Book_No) from Book group by Category 

--2)	List the book_No and the number of times the book is issued in the descending order of count.

select Book_No, Count(Book_No) As 'No of times Issued' from Issue group by Book_No order by [No of times Issued] desc
--3)	Find the maximum, minimum, total and average penalty amount in the member table.
select Max(Penalty_Amount) as 'Maximum penalty amount',Min(Penalty_Amount) as 'Minimum penalty amount'
, Sum(Penalty_Amount) as 'Total penalty amount',Avg(Penalty_Amount) as 'Average penalty amount'from Member

--4)	Display the member id and the no of books for each member that has issued more then 2 books.
select Member_Id, Count(Book_No) from Issue group by Member_Id 
Having count(Book_No)>2


--5)	Display the member id, book no and no of times the same book is issued by the member in the descending order of count.

select distinct Member_Id, Book_No, Count(Book_No) As 'No of times Issued' from Issue group by Member_Id,Book_No order by [No of times Issued] desc


select* from Issue
--6)	Display the month and no of books issued each month in the descending order of count.
select Month(Issue_Date) as 'month',count(Book_No)'No. of Books' from Issue Group by Month(Issue_Date)

--7)	  List the book_no of all the books that are not issued to any  
--member so far. 
Select Book_Name from Book Inner join Issue on Issue.Book_No=Book.Book_No where Issue_Date is null

--8)	List all the member id that exist in member table and has also at least one book issued by them.
select distinct Member.Member_Id from Member Inner Join Issue on Member.Member_Id=Issue.Member_Id
--9)	List the member ID with highest and lowest no of books issued. 
select Member_Id from Issue group by Book_No  Having Member_Id=Max(Book_No) 
--10)	List all the Issue_details for books issued in December and July without using any arithmetic, Logical or comparison operator.
--11)	 List the Book_No, Book_Name and Issue_date for all the books that are issued in month of December and belong to category Database.
--12)	 List the Member Id, Member Name and No of books Issued in the descending order of the count.
--13)	List the Book No, Book Name, Issue_date and Return_Date for all the books issued by Richa Sharma.
--14)	List the details of all the members that have issued books in Database category.
--15)	List all the books that have highest price in their own category.
--16)	List all the Issue_Details where Issue_date is not within the Acc_open_date and Return_date for that member.
--17)	List all the members that have not issued a single book so far.
--18)	List all the Members where No of books Issued exceeds the Max No of books allowed.
--19)	List all the members that have issued the same book as issued by Garima.
--20)	List the Book_Name, Price of all the books that are not returned for more then 30 days.
--21)	List all the authors and book_name that has more then 1 book written by them.
--22)	List the Member ID, Member Name of the people that have issued the highest and the lowest no of books.
--23)	List the details of highest 3 priced books.
--24)	List the total cost of all the books that are currently issued but not returned.
--25)	List the details of the book that has been issued maximum no of times

select* from Issu