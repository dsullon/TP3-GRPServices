
/**************************************/
/********* Stores Procedures **********/
/**************************************/

-- DROP PROCEDURE [dbo].[USPS_Login]
CREATE PROCEDURE [dbo].[USPS_Login]
	@usuario		nvarchar(50),
	@clave			nvarchar(50),
	@idAplicativo	int,
	@userID			int OUT,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY
	Declare @cant int
	Declare @perfilID int

	if len(@usuario) = 0
	begin
		RAISERROR('Ingrese el valor del Usuario',16,1)
	end

	if len(@clave) = 0
	begin
		RAISERROR('Ingrese el valor de la clave',16,1)
	end

	SELECT @cant = count(U.Id)
	FROM Usuario u
	WHERE Upper(U.CtaUsuario) = UPPER(@usuario)
	AND u.Estado = 1

	if (@cant > 0)
	begin

		declare @pass as varchar(50)

		Select @pass = dbo.UFN_PASS_DECRIPT(u.contrasenia) 
		from Usuario u 
		where u.CtaUsuario = @usuario
		AND U.Estado = 1
		
		if (@pass COLLATE Latin1_General_CS_AS = @clave Collate Latin1_General_CS_AS) 
		Begin
			
			SELECT @userID = U.Id, @perfilID = U.PerfilId
			FROM Usuario u
			WHERE Upper(U.CtaUsuario) = UPPER(@usuario)

			if NOT EXISTS(SELECT 1 FROM OpcionPerfil A 
							WHERE A.AplicacionId = @idAplicativo
							AND A.PerfilId = @perfilID)
			begin
				RAISERROR('Usted no tiene permisos para acceder al aplicativo',16,1)
			end
			else
			begin
				set @coderr = 0
				set @msgerr = 'OK' 
			end
		end
		else
			RAISERROR('Usuario o clave incorrectos',16,1)
	end
	else
		RAISERROR('Usuario no registrado',16,1)
	
END TRY
BEGIN CATCH
	DECLARE @mensajeError as varchar(4000)
	DECLARE @codSeveridad as int
	DECLARE @codStatus as int

	Select @mensajeError = ERROR_MESSAGE(),
		   @codSeveridad = ERROR_SEVERITY(),
		   @codStatus = ERROR_STATE()
	
	set @coderr = 1
	set @msgerr = @mensajeError

	--RAISERROR(@mensajeError, @codSeveridad, @codStatus)	
END CATCH


