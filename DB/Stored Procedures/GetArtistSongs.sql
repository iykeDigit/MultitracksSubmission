CREATE PROCEDURE [dbo].[GetArtistSongs]
	@artistId AS INT
AS
BEGIN

	SELECT Song.songID, Song.title, Song.bpm, Album.title, Album.imageURL
	FROM Song
	join Album
	on Song.albumID = Album.albumID
	WHERE
		Song.artistID = @artistId

END
