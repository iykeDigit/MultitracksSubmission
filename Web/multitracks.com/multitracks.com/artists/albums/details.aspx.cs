using DataAccess;
using MultiTracks.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class artists_albums_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            var id = Convert.ToInt32(Request.QueryString["id"]);
            var logic = new ApplicationLogic();
            var data = logic.RetrieveData(id);
            var albumData = logic.GetUniqueAlbums(data);

            AlbumsList.DataSource = albumData;
            AlbumsList.DataBind();

            var artistTitle = logic.GetArtistTitle(data);
            artist_title.InnerText = $"{artistTitle}: Albums";
        }
        catch (Exception ex)
        {
            var msg = ex.Message;
            throw;
        }

    }
}