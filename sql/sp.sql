use [3309];
create procedure insertEmployee(
	@EmpName varchar(50),
	@EmpAddress varchar(MAX),
	@EmpSalary int,
	@deptId int,
	@EmpId int output
)as
insert into tblEmployee1 values(@EmpName,@EmpAddress,@EmpSalary,@deptId) SET  @EmpId = @@identity;

declare @EmpId int
exec insertEmployee
	 @EmpName = "eshwar",
	 @EmpAddress="davangere",
	 @EmpSalary=28000,
	 @deptId = 8,
	 @EmpId = @EmpId output

select @EmpId as N'EmpId'
go

select * from DEPARTMENTS
create function GetDept(@id int)
returns varchar(50)
as
begin
declare DeptName from Departments 



CREATE FUNCTION GetDept(@id int)
RETURNS varchar(50)
AS
BEGIN
DECLARE @deptName varchar(50)
SET @deptName = (SELECT tblDept.deptName from tblDept where DeptId=@id)
REturn @deptName
End

CREATE FUNCTION CreateDate(@date Date)
RETURNS varchar(20)
AS
BEGIN
DECLARE @retVal varchar(20)
SET @retVal = '' + CAST(DAY(@date) AS varchar(5))+ '/' +CAST(MONTH(@date) AS varchar(4)) +'/'+ CAST(YEAR(@date) AS varchar(4))
Return @retVal
End

ALTER FUNCTION CreateDate(@date Date)
RETURNS varchar(20)
AS
BEGIN
DECLARE @retVal varchar(20)
SET @retVal = '' + DATENAME(DAY,@date)+ '/' +DATENAME(MONTH,@date) +'/'+ DATENAME(YEAR,@date)
Return @retVal
End

print dbo.CreateDate(GETDATE());

create FUNCTION GetAge(@dob Date)
RETURNS varchar(20)
AS
BEGIN
DECLARE @retVal varchar(20)
SET @retVal = '' + DATENAME(DAY,@date)+ '/' +DATENAME(MONTH,@date) +'/'+ DATENAME(YEAR,@date)
Return @retVal
End

create function getAllemp()
returns table
as
return(select * from tblEmployee1)

select EmpName from dbo.getAllemp()