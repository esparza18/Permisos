create database permisos;

create table usuarios(
idusuario int primary key auto_increment,
nombre varchar(50),
apellidop varchar(30),
apellidom varchar(30),
fechanacimiento varchar(50),
rfc varchar(50),
fkidaccesos varchar(50),
foreign key(fkidaccesos) references accesos(idaccesos));

-- refacciones 

create table productos(
CodigoBarras varchar(50) primary key, 
nombre varchar(50),
descripción varchar(100),
marca varchar(30));

-- taller

create table herramientas(
CodigoHerramienta varchar(50) primary key,
nombre varchar(100),
medida varchar(50),
marca varchar(50),
descripción varchar(50));

create table accesos(
idaccesos varchar(50) primary key,
lectura boolean,
escritura boolean,
eliminacion boolean,
actualizacion boolean);

insert into accesos values
('Administrador',true,true,true,true),
('Usuario',true,true,false,false),
('Invitado',false,false,false,false);

