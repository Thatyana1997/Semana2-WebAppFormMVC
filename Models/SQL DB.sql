create database ContactFormDB; 
GO 
use ContactFormDB;
go 

create table ContactMessages (
Id int identity(1,1) primary key, 
Nombre nvarchar(100) not null, 
Correo nvarchar(150) not null, 
Mensaje nvarchar(255) not null
);

go
select * from ContactMessages;

insert into ContactMessages values('karla','kbrenes@castrocarazo.ac.cr', 'prueba1');