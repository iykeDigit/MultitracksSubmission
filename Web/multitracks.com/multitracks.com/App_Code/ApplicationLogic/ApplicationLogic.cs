using DataAccess;
using MultiTracks.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ApplicationLogic
/// </summary>
public class ApplicationLogic
{
    private readonly SQL sql = new SQL();
    public ApplicationLogic()
    {
    }

    public string GetArtistTitle(DataRowCollection data) 
    {
        return data[0].ItemArray[17].ToString();
    }
    public DataRowCollection RetrieveData(int artistId) 
    {
        sql.Parameters.Add("@artistId", artistId);
        var executeSql = sql.ExecuteStoredProcedureDT("GetArtistDetails");
        var data = executeSql.Rows;
        return data;
    }

    public DataTable TopSongs(DataRowCollection data)
    {
        DataTable dataTable = new DataTable("Song");

        DataColumn title = new DataColumn("Title");  //0
        dataTable.Columns.Add(title);

        DataColumn bpm = new DataColumn("BPM"); //1
        dataTable.Columns.Add(bpm);

        DataColumn albumURL = new DataColumn("albumURL"); //2
        dataTable.Columns.Add(albumURL);

        DataColumn album_title = new DataColumn("album_title"); //3
        dataTable.Columns.Add(album_title);

        DataColumn artist_id = new DataColumn("artist_id"); //4
        dataTable.Columns.Add(artist_id);

        DataColumn img_alt = new DataColumn("img_alt"); //5
        dataTable.Columns.Add(img_alt);

        int count = 0;
        foreach (DataRow item in data)
        {
            var row = dataTable.NewRow();
            row[0] = item.ItemArray[4].ToString();
            row[1] = (decimal)item.ItemArray[5];
            row[2] = item.ItemArray[10].ToString();
            row[3] = item.ItemArray[9].ToString();
            row[4] = item.ItemArray[4];
            row[5] = item.ItemArray[4].ToString();

            dataTable.Rows.Add(row);
            count++;
            if (count == 3) break;
        }
        return dataTable;
    }

    public DataTable GetUniqueAlbums(DataRowCollection data) 
    {
        DataTable dataTable = new DataTable("Album");

        DataColumn album_id = new DataColumn("album_id"); //4
        dataTable.Columns.Add(album_id);
        dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["album_id"] };

        DataColumn albumURL = new DataColumn("albumURL");
        dataTable.Columns.Add(albumURL);

        DataColumn album_title = new DataColumn("album_title");
        dataTable.Columns.Add(album_title);

        DataColumn alt_text = new DataColumn("alt_text");
        dataTable.Columns.Add(alt_text);

        foreach (DataRow item in data)
        {
            var row = dataTable.NewRow();
            row[0] = item.ItemArray[6].ToString();
            row[1] = item.ItemArray[10].ToString();
            row[2] = item.ItemArray[9].ToString();
            row[3] = item.ItemArray[9].ToString();

            if (dataTable.Rows.Contains(row[0])) continue;
            dataTable.Rows.Add(row);
        }
        return dataTable;
    }

    public Artist GetArtistData(DataRowCollection data) 
    {
        var artistDetails = new Artist
        {
            artistID = (int)data[0].ItemArray[12],
            biography = data[0].ItemArray[13].ToString(),
            dateCreation = (DateTime)data[0].ItemArray[14],
            heroURL = data[0].ItemArray[15].ToString(),
            imageURL = data[0].ItemArray[16].ToString(),
            title = data[0].ItemArray[17].ToString()
        };
        return artistDetails;
    }


    public DataTable GetArtistSongs(DataRowCollection data)
    {
        DataTable dataTable = new DataTable("Song");

        DataColumn title = new DataColumn("Title");  //0
        dataTable.Columns.Add(title);

        DataColumn bpm = new DataColumn("BPM"); //1
        dataTable.Columns.Add(bpm);

        DataColumn albumURL = new DataColumn("albumURL"); //2
        dataTable.Columns.Add(albumURL);

        DataColumn album_title = new DataColumn("album_title"); //3
        dataTable.Columns.Add(album_title);

        DataColumn song_id = new DataColumn("song_id"); //4
        dataTable.Columns.Add(song_id);
        dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["song_id"] };

        DataColumn img_alt = new DataColumn("img_alt"); //5
        dataTable.Columns.Add(img_alt);

        foreach (DataRow item in data)
        {
            var row = dataTable.NewRow();
            row[0] = item.ItemArray[4].ToString();
            row[1] = (decimal)item.ItemArray[5];
            row[2] = item.ItemArray[10].ToString();
            row[3] = item.ItemArray[9].ToString();
            row[4] = item.ItemArray[0];
            row[5] = item.ItemArray[4].ToString();

            if (dataTable.Rows.Contains(row[4])) continue;
            dataTable.Rows.Add(row);
        }
        return dataTable;
    }

    public DataTable GetArtistBiography(DataRowCollection data) 
    {
        var artist = GetArtistData(data);
        var biography = ArtistBiograpghy(artist.biography);
        return biography;
    }

    private DataTable ArtistBiograpghy(string text)
    {
        var biographyLength = text.Length;
        DataTable dataTable = new DataTable("biography");

        DataColumn first_part = new DataColumn("first_part");  //0
        dataTable.Columns.Add(first_part);

        DataColumn second_part = new DataColumn("second_part");  //0
        dataTable.Columns.Add(second_part);

        var row = dataTable.NewRow();
        row[0] = text.Substring(0, biographyLength / 2);
        row[1] = text.Substring(biographyLength / 2);
        dataTable.Rows.Add(row);
        return dataTable;
    }
}