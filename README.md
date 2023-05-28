# Library

Let's design a library database. The project definitions for the Istanbul metropolitan municipality besiktas library are as follows. The library was designed as 3 floors (it can be increased later.) and each floor has surface area, floor type (parquet, stone, etc...), capacity, nickname. There are employees in the library, employees have name, surname, number and salary. There are books in the library. Books have title, author, number of pages, and date of publication. Books have sections. partitions have names. A book can have many chapters. Employees are responsible for Departments. A department can have only one employee. Sections belong to one floor.

The database solution of the above problem is as follows:

![image](https://user-images.githubusercontent.com/119699844/218276262-ad362069-49ab-4425-86c3-ff19269d6157.png)

create table Worker( Id int primary key IDENTITY (1,1), WorkerName varchar (100), Surname varchar (100), PhoneNumber varchar(10), Salary float );

create table Book( Id int primary key IDENTITY (1,1), BookTitle varchar(100), Author varchar(100), PageNumber int, PublishDate date );

create table Episode( Id int primary key IDENTITY (1,1), EpisodeName varchar(100), BookId int, FOREIGN KEY (BookId) REFERENCES Book(Id) );

create table Section( Id int primary key IDENTITY (1,1), SectionName varchar(100), FloorId int, WorkerId int, FOREIGN KEY (FloorId) REFERENCES LibraryFloor(Id), FOREIGN KEY (WorkerId) REFERENCES Worker(Id) );

create table LibraryFloor( Id int primary key IDENTITY (1,1), Area float, FloorType varchar(50), Capacity int, Nickname character varying(100) );

create table BookSection( Id int primary key IDENTITY (1,1), BookSectionName varchar(100), BookId int, SectionId int, FOREIGN KEY(BookId) REFERENCES Book(Id), FOREIGN KEY(SectionId) REFERENCES Section(Id) );

--The book sections of the workers called Ahmet

SELECT DISTINCT(Book.Name) FROM Employee, Section, BookSection, Book
WHERE Employee.Id = Section.EmployeeId
AND   Section.Id = BookSection.SectionId
AND   BookSection.BookId = Book.Id
AND   Employee.Name = 'Ahmet'

--Library floor of the workers called Ahmet

SELECT Floor.Nickname FROM Employee, Section, Floor
WHERE Employee.Id = Section.EmployeeId
AND   Section.FloorId = Floor.Id
AND   Employee.Name = 'Ahmet'

--Book names of the library floor called 'Giriş'

SELECT Book.Name FROM Floor, Section, BookSection, Book
WHERE Floor.Id = Section.FloorId
AND   Section.Id = BookSection.SectionId
AND   Book.Id = BookSection.BookId
AND   Floor.Nickname = 'giriş'
