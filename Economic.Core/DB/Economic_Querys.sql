
use master

drop database Economic

create database Economic

use Economic

create schema WEB

create table WEB.Entidades_Tipos(
	Id			int identity(1,1)	primary key,
	Descripcion	varchar(15)			not null
)

--Tipos de Entidades que existen en el sistema

insert into WEB.Entidades_Tipos values(
'Cliente'
)

insert into WEB.Entidades_Tipos values(
'Fiador'
)

insert into WEB.Entidades_Tipos values(
'Empleado'
)

create table WEB.Prestamos_Estados(
	Id			int identity(1,1)	primary key,
	Descripcion	varchar(15)			not null,
)

--Tipos de estados que van a tener los prestamos

insert into WEB.Prestamos_Estados values(
'Aprobado'
)

insert into WEB.Prestamos_Estados values(
'Finalizado'
)

insert into WEB.Prestamos_Estados values(
'Pendiente'
)

insert into WEB.Prestamos_Estados values(
'Revision'
)

insert into WEB.Prestamos_Estados values(
'Rechazado'
)

create table WEB.Prestamos_Detalle_Estados(
	Id			int identity(1,1)	primary key,
	Descripcion varchar(15)			not null
)

insert into WEB.Prestamos_Detalle_Estados values(
'Saldado'
)

insert into WEB.Prestamos_Detalle_Estados values(
'Adeudado'
)

create table WEB.Prestamos_Tipos(
	Id			int identity(1,1)	primary key,
	Descripcion varchar(40)			not null
)

insert into WEB.Prestamos_Tipos values(
'Personal'
)

insert into WEB.Prestamos_Tipos values(
'Hipotecario'
)

insert into WEB.Prestamos_Tipos values(
'Comercial'
)

create table WEB.Entidades (
	Id						int				identity(1,1)	primary key,
	TipoId					int				not null,
	Nombre					varchar(50)		not null,
	Apellido				varchar(50)		not null,
	Numero_Identidad		numeric(11)		not null,
	Telefono				numeric(10),
	Celular					numeric(10),
	Direccion				varchar(100)	not null,
	Estado_Civil			varchar(15)		not null,
	Fecha_Nacimiento		date			not null,
	Genero					varchar(1)		not null,
	Correo					varchar(30)		not null,
	Nombre_Empresa			varchar(50)		not null,
	Rol_Empresa				varchar(50)		not null,
	Telefono_Empresa		numeric(10)		not null,
	Ingresos				int				not null,
	Usuario					varchar(50),
	Password				varchar(50),
	constraint fk_Clasificacion foreign key (TipoId) references WEB.Entidades_Tipos(Id)
)

create table WEB.Prestamo_Master(
	Id					int			identity(1,1)	primary key,
	PrestatarioId		int			not null,
	FiadorId			int			not null,
	TipoId				int			not null,
	Importe				int			not null,
	Numero_Cuotas		numeric(2)	not null,
	Interes_Porciento	numeric(2)	not null,
	Fecha_Solicitud		datetime	not null,
	Fecha_Aprobado		datetime	not null,
	Plazo_Dias			int			not null,
	EstadoId			int			not null,
	constraint fk_cliente	foreign key (PrestatarioId)	references WEB.Entidades(Id),
	constraint fk_garante	foreign key (FiadorId)		references WEB.Entidades(Id),
	constraint fk_Estado	foreign key (EstadoId)		references WEB.Prestamos_Estados(Id),
	constraint fk_Tipo		foreign key (TipoId)		references WEB.Prestamos_Tipos(Id)
)

create table WEB.Prestamo_Solicitud(
	Id					int			identity(1,1)	primary key,
	PrestatarioId		int			not null,
	FiadorId			int			not null,
	TipoId				int			not null,
	Importe				int			not null,
	Numero_Cuotas		numeric(2)	not null,
	Interez_Porciento	numeric(2)	not null,
	Fecha_Solicitud		datetime	not null,
	EstadoId			int			not null,
	constraint fk_cliente2	foreign key (PrestatarioId)	references WEB.Entidades(Id),
	constraint fk_garante2	foreign key (FiadorId)		references WEB.Entidades(Id),
	constraint fk_Estado2	foreign key (EstadoId)		references WEB.Prestamos_Estados(Id),
	constraint fk_Tipo2		foreign key (TipoId)		references WEB.Prestamos_Tipos(Id)
)

create table WEB.Prestamo_Detalle(
	Id					int			identity(1,1)	primary key,
	Prestamo_Master_Id	int			not null,
	Fecha_Vencimiento	datetime	not null,
	Fecha_Pago			datetime,
	Cuota_Numero		int			not null,
	PagoCapital			int			not null,
	Interez				float		not null,
	Amortizacion		float		not null,
	Mora				float		not null		default 0.0,
	Descuento			float		not null		default 0.0,
	Saldo				float		not null,
	EstadoId			int			not null,
	constraint fk_Identificacion	foreign key (Prestamo_Master_Id)	references WEB.Prestamo_Master(Id),
	constraint fk_Estado_Prestamos	foreign key (EstadoId)				references WEB.Prestamos_Detalle_Estados(Id)
)

create table WEB.Documentos(
	Id					int				identity(1,1)	primary key,
	EntidadId			int				not null,
	Prestamo_MasterId	int				not null,
	CaraA				varchar(max)	not null,
	CaraB				varchar(max),
	Descripcion			text			not null,
	constraint fk_dueno foreign key (EntidadId) references WEB.Entidades(Id),
	constraint fk_Prestamo foreign key (Prestamo_MasterId) references WEB.Prestamo_Master(Id)
)

create table WEB.Bienes_Declarados(
	Id					int				identity(1,1)	primary key,
	EntidadId			int				not null,
	Prestamo_MasterId	int				not null,
	Descripcion			varchar(100)	not null,
	Cantidad			int				not null,
	constraint fk_Prestamo2 foreign key (Prestamo_MasterId) references WEB.Prestamo_Master(Id)
)

create table Targeta(
	Id int identity(1,1) primary key,
	Numero numeric(16) not null,
	EntidadId int not null,
	constraint fk_Entidad foreign key (EntidadId) references WEB.Prestamo_Master(Id)
)




select * fr