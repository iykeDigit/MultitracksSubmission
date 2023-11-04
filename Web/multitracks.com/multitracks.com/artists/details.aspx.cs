using DataAccess;
using MultiTracks.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class artists_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sql = new SQL();
        try
        {
            var logic = new ApplicationLogic();
            var id = Convert.ToInt32(Request.QueryString["id"]);
            var data = logic.RetrieveData(id);
            var artistbiography = logic.GetArtistBiography(data);
            artist_biography.DataSource = artistbiography;
            artist_biography.DataBind();

            var artistTitle = logic.GetArtistTitle(data);
            artist_title.InnerText = $"{artistTitle}: Biography";

        }
        catch (Exception)
        {

            throw;
        }
    }

    
}