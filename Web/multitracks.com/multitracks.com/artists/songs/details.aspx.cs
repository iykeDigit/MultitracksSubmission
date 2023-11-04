using DataAccess;
using MultiTracks.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ArtistDetails_artists_songs_details : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        var sql = new SQL();
        try
        {
            var id = Convert.ToInt32(Request.QueryString["id"]);
            var logic = new ApplicationLogic();
            var data = logic.RetrieveData(id);
            var songs = logic.GetArtistSongs(data);
            SongsList.DataSource = songs;
            SongsList.DataBind();

            var artistTitle = logic.GetArtistTitle(data);
            artist_title.InnerText = $"{artistTitle}: Songs";
        }
        catch (Exception ex)
        {
            var msg = ex.Message;
            throw;
        }
    }
}