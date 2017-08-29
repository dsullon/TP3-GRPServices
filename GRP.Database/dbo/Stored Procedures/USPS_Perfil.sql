
-- DROP PROCEDURE [dbo].[USPS_Perfil]
CREATE PROCEDURE [dbo].[USPS_Perfil]
	@idperfil		int,
	@idapp			int,
	@nombre			varchar(50),
	@coderr			int OUT,
	@msgerr			varchar(1000) OUT

AS
BEGIN TRY

	SELECT	P.Id,
			P.Nombre,
			P.Descripcion,
			p.AplicacionId,
			A.Descripcion as Aplicacion
	FROM Perfil P
		inner join Aplicacion A on P.AplicacionId = A.Id and A.Estado = 1
	WHERE ((@idperfil = -1) OR (P.Id = @idperfil))
	AND ((@idapp = -1) OR (P.AplicacionId = @idapp))
	AND ((@nombre = '') OR (UPPER(P.Nombre) like '%' + UPPER(@nombre) + '%'))
	
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


