using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//add a reference to the lib.
using System.ServiceModel.Web;

namespace WebApplicationWithAJAX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChinookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ChinookService.svc or ChinookService.svc.cs at the Solution Explorer and start debugging.
    public class ChinookService : IChinookService
    {

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "artists")]
        public IEnumerable<Artist> getAllArtists()
        {
            DataChinookDataContext cdc = new DataChinookDataContext("Data Source=NO142145;Initial Catalog=Chinook;Integrated Security=True");
            cdc.DeferredLoadingEnabled = false;

            var artists = from a in cdc.Artists select a;
            return artists;
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "artists/{id}")]
        public Artist getArtistsById(string id)
        {
            DataChinookDataContext cdc = new DataChinookDataContext("Data Source=NO142145;Initial Catalog=Chinook;Integrated Security=True");
            cdc.DeferredLoadingEnabled = false;

            var artist = cdc.Artists.First(a => a.ArtistId == Int32.Parse(id));
            return artist;
        }
    }
}
