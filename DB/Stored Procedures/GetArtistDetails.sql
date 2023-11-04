CREATE PROCEDURE [dbo].[GetArtistDetails]
	@artistId AS INT

AS
BEGIN
select Song.songID, Song.dateCreation, Song.albumID, Song.artistID, Song.title, song.bpm,
        Album.albumID, Album.dateCreation, Album.artistID, Album.title, Album.imageURL, Album.year,
				Artist.artistID, Artist.biography, Artist.dateCreation, Artist.heroURL, Artist.imageURL, Artist.title 
from Song
join Album
on Song.albumID = Album.albumID
join Artist
on Artist.artistID = Song.artistID
where Song.artistID = @artistId
END
