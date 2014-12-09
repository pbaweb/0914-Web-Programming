using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplicationWithAJAX
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChinookService" in both code and config file together.
    [ServiceContract]
    public interface IChinookService
    {
        [OperationContract]
        IEnumerable<Artist> getAllArtists();

        [OperationContract]
        Artist getArtistsById(string id);
    }
}
