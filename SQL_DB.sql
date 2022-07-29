create database CrudDb
go
use CrudDb
go
create table Crud_table
(
id int identity primary key,
name varchar(60),
salary decimal
)
go
insert into Crud_table values('Neha',50000)
go
insert into Crud_table values('SNeha',10000)
go
insert into Crud_table values('Neharica',5000)
go
insert into Crud_table values('Nehal',90000)
go
select * from Crud_table

