
-- DROP PROCEDURE [dbo].[USPS_Usuario]
CREATE PROCEDURE [dbo].[USPS_Usuario]
	@idUsuario		int,
	@nombres		varchar(100),
	@idPerfil		int,
	@estado			int,
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SELECT	U.Id,
			U.PerfilId,
			P.Nombre as perfil, 
			U.CtaUsuario,
			U.Apellidos,
			U.Nombres,
			U.Cargo,
			U.Email,
			U.telefono,
			U.CambiarContrasenia,
			U.FechaVencimientoCta,
			U.FechaVencimiento,
			U.Estado
	FROM Usuario U
		INNER JOIN Perfil P ON U.PerfilId = P.Id
	WHERE ((@estado = -1) OR (U.Estado = @estado))
	AND ((@idUsuario = -1) OR (U.Id = @idUsuario))
	AND ((RTRIM(LTRIM(@nombres)) = '') OR ((U.Nombres + ' ' + U.Apellidos) LIKE '%' + @nombres + '%'))
	AND ((@idPerfil = -1) OR (U.PerfilId = @idPerfil))
	
	Set @coderr = 0
	Set @msgerr = 'OK'
	
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


