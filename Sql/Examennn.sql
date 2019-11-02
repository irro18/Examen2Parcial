Create database Examen2
go
use Examen2
go

create table usuarios(
id_usuario int primary key identity(1,1),
nombre nvarchar(50) not null,
correo nvarchar(50) not null,
contraseña nvarchar(50) not null
)

insert into usuarios
values
('Ivan Renteria', 'ivan18ro@gmail.com', '123')
go

select * from usuarios

create procedure getUsuarios
as
select * from usuarios 
go

create procedure addUsuario
(
	@nombre nvarchar(50),
	@correo nvarchar(50),
	@contraseña nvarchar(50),
	@hasError bit out
)
as
begin try
	set @hasError = 0;
	insert into usuarios
	values
	(@nombre, @correo, @contraseña)
end try
begin catch
	set @hasError = 1;
end catch
go

create procedure deleteUsuario
(
	@id_usuario int,
	@hasError bit out
)
as
set @hasError = 1
begin try
if exists(select top 1 1 from usuarios where id_usuario = @id_usuario)
begin
	set @hasError = 0
	delete usuarios where id_usuario = @id_usuario
end
end try
begin catch
	set @haserror = 1;
end catch
go