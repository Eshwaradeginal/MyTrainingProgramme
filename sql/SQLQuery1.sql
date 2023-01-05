use [3309]
--create table tblEmployee1
--(
--	EmpId int PRIMARY KEY IDENTITY(1001,1),
--	EmpName varchar(50) NOT NULL,
--	EmpAddress varchar(MAX),
--	EmpSalary money NOT NULL
--)
--create table Dept(
--	Deptid int PRIMARY KEY IDENTITY(1001,1),
--	DeptName varchar(50) NOT NULL
--)

select * from tblEmployee1

select EmpName from tblEmployee1 where EmpName like 'a%';

select min(EmpSalary) as MINSAL,max(EmpSalary) as MAXSAL from tblEmployee1;