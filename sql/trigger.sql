use [3309]

create table tblCustomer(
custId int primary key,
custName varchar(50),
custAddress varchar(200) not null,
BillDate date default GetDate(),BillAmount money
)

create table customer_audit(
	id int primary key identity(1,1),
	details varchar(MAX) not null
)

create trigger onInsertCustomer ON tblCustomer
for Insert
as
begin
declare @id int
select @id=custId from inserted
insert into customer_audit values('customer with id'+(CAST(@id as varchar)) + 'is instrted into database on '+(CAST(GETDATE() as varchar)))
end

insert into tblCustomer values(111,'abc','banglore','12/12/22',5000)

select * from customer_audit

select * from tblcustomer

create trigger onDeleteCustomer
on tblCustomer
After Delete
as
begin
declare @id int 
select @id = custId from deleted
Insert into Customer_Audit values('customer with id' + (CAST(@id as varchar)) +
' inserted info database on' + cast(getDate() as varchar(50)))
end

delete from tblCustomer where custId = 111;
----------------------------------------------------------------
create trigger onUpdateTrigger
on tblCustomer
After Update
as
begin
declare @id int 
declare @oldname varchar(50)
declare @newname varchar(50)
select @id = custId from inserted
select @oldname = custName from deleted
select @newname = custName from inserted
Insert into Customer_Audit values('customer with id' + (CAST(@id as varchar)) +
' updated with'+@newname+'replacing the' +@oldname +'on' + cast(getDate() as varchar(50)))
end

select * from tblCustomer
update  tblCustomer set custName = ' eshwar ' where custId = 111;


insert into tblCustomer values(112,'abc','banglore','12/12/22',5000)
insert into tblCustomer values(113,'abcde','banglore','12/12/22',5000)
insert into tblCustomer values(111,'abcgv ','banglore','12/12/22',5000)

select Distinct EmpAddress from tblEmployee

select * from tblEmployee where EmpAddress in ('Bangalore','Hassan','Punjab')
select * from tblEmployee where EmpAddress not in ('Bangalore','Hassan','Punjab')

create table tblContact(
	contactId int primary key identity(1,1),
	contactName varchar(50) not null,
	contactCity varchar(250) not null,
)

insert into tblContact values('nirusha','gopanal')
insert into tblContact values('pista','Banaglore')

select EmpName, EmpAddress from tblEmployee where EmpId <= 1050

--delete using top
delete top(2) percent from tblEmployee where EmpAddress = 'Bangalore'

select 'TotalSalary' as totalsalarybydept, [7], [8]
from (select Department_Id, EmpSalary from tblEmployee1) as sourcetable
PIVOT
(
sum(EmpSalary) for Department in ([7],[8]) 
)
as Pivottabel

select * from tblEmployee1