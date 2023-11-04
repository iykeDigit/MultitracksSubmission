CREATE PROCEDURE [dbo].[GetArtistAlbums]
	@artistId AS INT
AS
BEGIN

	SELECT *
	FROM Album
	WHERE
		artistID = @artistId

END
