using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MultiTracks.Models;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
using System.Web.ModelBinding;

public partial class artistDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        try
        {
            var logic = new ApplicationLogic();
            var data = logic.RetrieveData(5);

            var artistDetails = logic.GetArtistData(data);

            banner_img.ImageUrl = artistDetails.imageURL;
            banner_img.ID = artistDetails.artistID.ToString();
            banner_img.AlternateText = artistDetails.title;
            hero_img.ImageUrl = artistDetails.heroURL;
            hero_img.AlternateText = artistDetails.title;
            
            artistTitle.InnerText = artistDetails.title.ToString();
            theLink.HRef += artistDetails.artistID;
            album_link.HRef += artistDetails.artistID;
            biography.HRef += artistDetails.artistID;
            first_album_link.HRef += artistDetails.artistID;
            first_song_link.HRef += artistDetails.artistID;

            //Artist Biography
            var artistbiography = logic.GetArtistBiography(data);
            artist_biography.DataSource = artistbiography;
            artist_biography.DataBind();

            //top songs
            var topsongsTable = logic.TopSongs(data);
            TopSongsList.DataSource = topsongsTable;
            TopSongsList.DataBind();

            //top albums
            var topAlbumsTable = logic.GetUniqueAlbums(data);
            albumList.DataSource = topAlbumsTable;
            albumList.DataBind();
        }
        catch (Exception ex)
        {
            var msg = ex.Message;
            throw;
        }
    }   
}