USE master
GO
IF EXISTS(SELECT 1 FROM SysDataBases WHERE NAME='RetoTecnico')
	DROP DATABASE RetoTecnico

CREATE DATABASE RetoTecnico on (
	NAME='RetoTecnico',
	FILENAME='E:\base\RetoTecnico.Mdf'--Agregar Segun donde quieras guarda la bdd-
)
GO

Use RetoTecnico
Create TABLE Agencias(
	Nombre varchar(30) PRIMARY KEY,
	Pais varchar(50),
)
GO
Create TABLE Motor(
	CodFabrica varchar(3) PRIMARY KEY,
	Cantidad int,
	Tipo varchar(35),
)
GO
Create TABLE Planeta(
	Nombre varchar(30) PRIMARY KEY,
	Informacion varchar(100),
	Distancia bigint,
)
GO
Create TABLE LanzadorDeEnergia(
	CodFabrica varchar(3) PRIMARY KEY,
	Peso int,
	Tamaño int,
)
GO
GO
Create TABLE Nave(
	Numero INT IDENTITY(1,1) PRIMARY KEY,
	Firma varchar(30),
	Objetivo varchar(100),
	Nombre varchar(30),
	Combustible varchar(30),
	Potencia int,
	velocidad int,
	FechaDespegue Datetime Default GETDATE(),
	SistemaDePropulsion varchar(50),
	Peso int,
	Tipo int--1-VehiculoLanzadera 2-NoTripulada 3-Tripulada
	Foreign Key (Firma) References Agencias(Nombre)
)
GO
Create TABLE VehiculoLanzadera(
	Numero int PRIMARY KEY,
	Empuje int,
	Transporte int,
	CodFabricaV varchar(3),
	Foreign Key(Numero) references Nave(Numero),
	Foreign Key(CodFabricaV) references LanzadorDeEnergia(CodFabrica)	
)
GO
CREATE TABLE NoTripulada(
	Numero int PRIMARY KEY,
	EmpujeN int,
	Camara bit,
	ActividadN bit,
	Aterrizador varchar(30),
	CodFabricaM varchar(3),
	NombrePlaneta varchar(30),
	Foreign Key(Numero) references Nave(Numero),
	Foreign Key(CodFabricaM) references Motor(CodFabrica),
	Foreign Key(NombrePlaneta) references Planeta(Nombre)
)
GO
Create TABLE Tripulada(
	Numero int PRIMARY KEY,
	Misiones varchar(30),
	Capacidad int,
	Orbita varchar(30),
	Actividad bit,
	PersonasABordo int,
	Foreign Key(Numero) references Nave(Numero),
)
GO
------------------------------------------------------------------------------------------------------------------
Insert into Planeta(Nombre,Informacion,Distancia) values ('Marte','cuarto planeta en orden de distancia al Sol y el segundo más pequeño del sistema solar',102000000)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Mercurio','planeta del sistema solar más cercano al Sol y el más pequeño.',149597900)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Venus','segundo planeta del sistema solar en orden de proximidad al Sol y el tercero en cuanto a tamaño.',40000000)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Urano','séptimo planeta del sistema solar, el tercero de mayor tamaño, y el cuarto más masivo',4300000000000)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Jupiter','planeta más grande del sistema solar y el quinto en orden de lejanía al Sol',587000000)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Saturno','sexto planeta del sistema solar contando desde el Sol, el segundo en tamaño y masa',1300000000)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Neptuno','octavo planeta en distancia respecto al Sol y el más lejano del sistema solar',4345000000000)
Insert into Planeta(Nombre,Informacion,Distancia) values ('Próxima Centauri b','Fuera del sistema solar,muchas similitudes con la tierra.',4)

INSERT INTO Motor (CodFabrica,Cantidad,Tipo) Values ('33D',5,'Motor a Oxigeno')
INSERT INTO Motor (CodFabrica,Cantidad,Tipo) Values ('31D',1,'Motor a Nitrogeno')
INSERT INTO Motor (CodFabrica,Cantidad,Tipo) Values ('99F',6,'Motor a Gasolina')
INSERT INTO Motor (CodFabrica,Cantidad,Tipo) Values ('99X',16,'combustión de monometilhidracina')
INSERT INTO Motor (CodFabrica,Cantidad,Tipo) Values ('65E',9,'combustión nuclear')

INSERT INTO Agencias(Nombre,Pais) Values ('Nasa','Estados Unidos')
INSERT INTO Agencias(Nombre,Pais) Values ('FKA','Rusia')
INSERT INTO Agencias(Nombre,Pais) Values ('ESA','Continente:Europa')
INSERT INTO Agencias(Nombre,Pais) Values ('CMSA','China')
INSERT INTO Agencias(Nombre,Pais) Values ('CSA/ASC','Canadiense')
INSERT INTO Agencias(Nombre,Pais) Values ('JAXA','Japonesa')
INSERT INTO Agencias(Nombre,Pais) Values ('ASI','Italiana')
INSERT INTO Agencias(Nombre,Pais) Values ('CNES','Francia')

Insert Into LanzadorDeEnergia(Codfabrica,Peso,Tamaño) Values('STV',2400000,60)
Insert Into LanzadorDeEnergia(Codfabrica,Peso,Tamaño) Values('22U',1000000,40)
Insert Into LanzadorDeEnergia(Codfabrica,Peso,Tamaño) Values('49A',2150000,45)
GO
/************************************************* Inventario Naves Default *************************************************/	
Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Lanzar una carga','Pluton V','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,1) 
Insert Into VehiculoLanzadera values(1,3000,200,'STV')

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Lanzar una carga','Pluton VI','Liquido',3000,4000,'Propulsion electromagnetica',Getdate(),2099,1) 
Insert Into VehiculoLanzadera values(2,3000,200,'22U')

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Lanzar una carga','Pluton VII','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,1) 
Insert Into VehiculoLanzadera values(3,3000,200,'STV')


Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Evaluar el comportamiento humano','Trip V','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,3)
Insert Into Tripulada values(4,'Apolo',8,'209',1,3)

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Evaluar el comportamiento humano','Trip VI','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,3)
Insert Into Tripulada values(5,'Apolo',5,'209',1,2)

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Evaluar el comportamiento humano','Trip V','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,3)
Insert Into Tripulada values(6,'Apolo',7,'209',1,3)

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Sacar foto a la atmosfera','Martus V','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,2)
Insert Into NoTripulada values(7,290,1,1,200,'33D','Marte')

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Sacar foto a la atmosfera','Uranus V','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,2)
Insert Into NoTripulada values(8,290,1,1,200,'99F','Urano')

Insert Into Nave(firma,objetivo,nombre,Combustible,potencia,velocidad,SistemaDePropulsion,FechaDespegue,peso,tipo) values('Nasa','Sacar foto a la atmosfera','Uranus V','Queroseno',3000,4000,'Propulsion electromagnetica',Getdate(),2099,2)
Insert Into NoTripulada values(9,290,1,1,200,'99F','Urano')
GO
/************************************************* Stored Procedures *************************************************/	
CREATE PROCEDURE CrearNaveLanzadera
@Firma varchar(30),
@Objetivo varchar(100),
@Nombre varchar(30),
@Combustible varchar(30),
@Potencia int,
@Velocidad int,
@SistemaDePropulsion varchar(50),
@Peso int,
@Empuje int,
@Transporte int,
@CodFabrica varchar(3)
as
begin
	if not exists(select 1 from Agencias where @Firma=Nombre)
		return -1
	if not exists(select 1 From LanzadorDeEnergia where @CodFabrica=CodFabrica)
		return -2

	begin transaction
		Declare @ultimo int
		insert Nave(Firma,Objetivo,Nombre,Combustible,potencia,velocidad,SistemaDePropulsion,Peso,Tipo) values(@firma,@objetivo,@nombre,@Combustible,@potencia,@velocidad,@SistemaDePropulsion,@peso,1)
		set @ultimo=ident_current('Nave')
		if @@ERROR<>0
		begin
			return @@ERROR
			rollback tran
		end
		insert VehiculoLanzadera values(@ultimo,@Empuje,@Transporte,@CodFabrica)
		if @@ERROR<>0
		begin
			return @@ERROR
			rollback tran
		end
		commit tran
		return 1
end
GO
DECLARE @resultado INT
EXEC @resultado=CrearNaveLanzadera 'Nasa','Lanzar una carga al espacio', 'Saturno V','Queroseno',3200,4000,'Propulsion Electromagnetica',2900,3500,118,'STV'
SELECT @resultado
GO

------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CrearNaveTripulada
@Firma varchar(30),
@Objetivo varchar(100),
@Nombre varchar(30),
@Combustible varchar(30),
@Potencia int,
@velocidad int,
@SistemaDePropulsion varchar(50),
@Peso int,
@Misiones varchar(30),
@Capacidad int,
@Orbita varchar(3),
@Personas int
as
begin
	if not exists(select 1 from Agencias where @Firma=Nombre)
		return -1
	if(@Capacidad<@Personas)
		return -2
	begin transaction
		Declare @ultimo int
		insert Nave(Firma,Objetivo,Nombre,Combustible,potencia,velocidad,SistemaDePropulsion,Peso,Tipo) values(@firma,@objetivo,@nombre,@Combustible,@potencia,@velocidad,@SistemaDePropulsion,@peso,3)
		set @ultimo=ident_current('Nave')
		if @@ERROR<>0
		begin
			return -3
			rollback tran
		end
		insert Tripulada values(@ultimo,@Misiones,@Capacidad,@Orbita,1,@Personas)
		if @@ERROR<>0
		begin
			return -3
			rollback tran
		end
		commit tran
		return 1
end
GO

DECLARE @resultado int
exec @resultado=CrearNaveTripulada'FKA','Observar el comportamiento humano en el espacio','Spectrum','Nuclear',40000,23000,'Queroseno',2900,'Apolo',7,'290',3
select @resultado
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CrearNaveNoTripulada
@Firma varchar(30),
@Objetivo varchar(100),
@Nombre varchar(30),
@Combustible varchar(30),
@Potencia int,
@velocidad int,
@SistemaDePropulsion varchar(50),
@Peso int,
@Empuje decimal,
@aterrizador varchar(30),
@CodFabrica varchar(3),
@NombrePlaneta varchar(30)
as
begin
	if not exists(select 1 from Agencias where @Firma=Nombre)
		return -1
	if not exists (select 1 From Motor where @CodFabrica=CodFabrica)
		return -2
	if not exists(select 1 from Planeta Where @NombrePlaneta=Planeta.Nombre)
		return-3

	begin transaction
		Declare @ultimo int
		insert Nave(Firma,Objetivo,Nombre,Combustible,potencia,velocidad,SistemaDePropulsion,Peso,Tipo) values(@firma,@objetivo,@nombre,@Combustible,@potencia,@velocidad,@SistemaDePropulsion,@peso,2)
		set @ultimo=ident_current('Nave')
		if @@ERROR<>0
		begin
			return @@error
			rollback tran
		end
		insert NoTripulada values(@ultimo,@Empuje,1,1,@aterrizador,@CodFabrica,@NombrePlaneta)
		if @@ERROR<>0
		begin
			return @@error
			rollback tran
		end
		commit tran
		return 1
end
GO

DECLARE @resultado int
exec @resultado=CrearNaveNoTripulada 'CMSA','Fotos a Planetas','Mart12','Nuclear',40000,23000,'Queroseno',2900,300,290,'33D','Urano'
select @resultado
GO
------------------------------------------------------------------------------------------------------------------
CREATE proc CantidadDeNavesEnPlaneta
@Planeta varchar(30)
as
begin
	select Nave.*,NoTripulada.*,Planeta.*
	from Nave inner join NoTripulada inner join Planeta
	on NoTripulada.NombrePlaneta=planeta.Nombre
	on NoTripulada.Numero=Nave.Numero
	where @Planeta=planeta.Nombre
end

execute CantidadDeNavesEnPlaneta 'Urano'
GO
------------------------------------------------------------------------------------------------------------------
Create PROCEDURE CantidadDeNavesLanzadas
as
begin
	select  Nave.* ,Tripulada.Actividad,Misiones,Capacidad,Orbita,PersonasABordo,VehiculoLanzadera.Empuje,CodFabricaV,Transporte,EmpujeN,Camara,ActividadN,Aterrizador,CodFabricaM,NombrePlaneta
	From Tripulada full join NoTripulada full join Nave full join VehiculoLanzadera
	on Nave.Numero=VehiculoLanzadera.Numero
	on Nave.Numero=NoTripulada.Numero
	on Nave.Numero=Tripulada.Numero
	order by Nave.Numero 
end
GO
exec CantidadDeNavesLanzadas
GO
------------------------------------------------------------------------------------------------------------------
Create Procedure PasajeroEnElEspacio
as
begin
	select SUM(Tripulada.Capacidad) as 'Pasajeros en el espacio'
	From Tripulada
end
GO
exec PasajeroEnElEspacio
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SacarDeActividaUnaNave
@Numero int,
@TripuladaoNoTripulada varchar(20)
as
begin
	if not exists(select 1 From Nave where @Numero=Numero)
		return -1
	Declare @error int
	if(@TripuladaoNoTripulada='Tripulada')
	begin
		if exists(select 1 from Tripulada where PersonasABordo>0 and @numero=tripulada.Numero)
			return -2
		Update Tripulada set Actividad=0
		where @Numero=Tripulada.Numero
		set @error=@@ERROR
	end
	else if(@TripuladaoNoTripulada='NoTripulada')
	begin	    
		Update NoTripulada set ActividadN=0
		Where @Numero=NoTripulada.Numero
		set @error=@@ERROR
	end
	if(@error=0)
		return 1
	else
		return -3
end
GO
DECLARE @resultado int
exec @resultado=SacarDeActividaUnaNave 8, 'NoTripulada'
select @resultado
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE MandarHumanoALaTierra
@Numero int,
@Cantidad int
as
begin
	if not exists(select 1 From Nave where @Numero=Numero)
		return -1
	declare @resultado int
	Select @resultado=Tripulada.PersonasABordo-@Cantidad
	From Tripulada
	where @Numero=tripulada.Numero
	if(@resultado<0)
		return -2
	Update Tripulada set PersonasABordo=@resultado
	where @Numero=Tripulada.Numero
	if @@ERROR<>0
		return -3
	return 1
end
GO
DECLARE @resultado int
exec @resultado=MandarHumanoALaTierra 3,1
select @resultado
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE MandarHumanoANave
@Numero int,
@Cantidad int
as
begin
	if not exists(select 1 From Nave where @Numero=Numero)
		return -1
	declare @resultado int
	declare @max int
	Select @resultado=Tripulada.PersonasABordo+@Cantidad
	From Tripulada
	where @Numero=tripulada.Numero
	select @max=Tripulada.Capacidad
	from Tripulada
	where @Numero=Tripulada.Numero

	if(@resultado>@max)
		return -2
	Update Tripulada set PersonasABordo=@resultado
	where @Numero=Tripulada.Numero 
	if @@ERROR<>0
		return -3
	return 1
end
GO
DECLARE @resultado int
exec @resultado=MandarHumanoANave 3,5
select @resultado
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROC BuscarNave
@Numero int
as
begin
	declare @tipo int
	set @tipo=(select Nave.Tipo
	From Nave
	where @Numero=Nave.Numero)
	if (@tipo=1)
	begin
		Select Nave.*,VehiculoLanzadera.Empuje,CodFabricaV,Transporte
		From Nave inner Join VehiculoLanzadera
		on Nave.Numero=VehiculoLanzadera.Numero
		where @Numero=nave.Numero
	end
	else if(@tipo=2)
	begin
		Select Nave.*,NoTripulada.EmpujeN,Camara,ActividadN,Aterrizador,CodFabricaM,NombrePlaneta
		From Nave inner join NoTripulada
		on Nave.Numero=NoTripulada.Numero
		where @Numero=nave.Numero
	end
	else if(@tipo=3)
	begin
		Select Nave.*,Tripulada.Actividad,Misiones,Capacidad,Orbita,PersonasABordo
		From Nave inner join Tripulada
		on Nave.Numero=Tripulada.Numero
		where @Numero=Nave.Numero
	end
end
GO
exec BuscarNave 5
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROC BuscarNavePorTipo
@Tipo varchar(20)
as
begin
	if(@Tipo='Tripulada')
	begin
		Select Nave.*,Tripulada.Actividad,Misiones,Capacidad,Orbita,PersonasABordo
		From Nave inner join Tripulada
		on Nave.Numero=Tripulada.Numero
	end
	else if(@Tipo='No Tripulada')
	begin
		Select Nave.*,NoTripulada.EmpujeN,Camara,ActividadN,Aterrizador,CodFabricaM,NombrePlaneta
		From Nave inner join NoTripulada
		on Nave.Numero=NoTripulada.Numero
	end
	else if(@Tipo='Lanzadera')
	begin
		Select Nave.*,VehiculoLanzadera.Empuje,CodFabricaV,Transporte
		From Nave inner Join VehiculoLanzadera
		on Nave.Numero=VehiculoLanzadera.Numero
	end
end
GO
exec BuscarNavePorTipo 'No Tripulada'
-------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ListadoAgencias
as
begin
	select *
	From Agencias
end
GO
exec ListadoAgencias
-------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ListadoPlanetas
as
begin
	select*
	From Planeta
end
GO
exec ListadoPlanetas
-------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ListadoMotores
as
begin
	select *
	From Motor
end
GO
exec ListadoMotores
-------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ListadoLanzadores
as
begin
	select*
	From LanzadorDeEnergia
end
GO
exec ListadoLanzadores