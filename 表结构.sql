create database jiaoshiWeb
go

use jiaoshiWeb
go

--管理员登录信息
create table denglu
(
code nvarchar(20) not null primary key,
password nvarchar(100) not null,
name nvarchar(20) not null,
sex nvarchar(10) not null,
birthday datetime not null
)
go

insert into denglu values('admin','123456','admin',N'男','2000-01-01')
go

--教师信息
create table jiaoshixx
(
code nvarchar(20) not null primary key,
name nvarchar(20) not null,
sex nvarchar(10) not null,
phone nvarchar(20) not null,
address nvarchar(100) not null,
birthday datetime not null,
course nvarchar(100) not null
)
go
