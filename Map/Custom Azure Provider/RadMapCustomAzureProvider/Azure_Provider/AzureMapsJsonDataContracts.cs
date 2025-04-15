using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RadMapCustomAzureProvider.Azure_Provider
{
    [DataContract]
    public class AzureResponse
    {
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public Summary Summary { get; set; }

        [DataMember(Name = "results", EmitDefaultValue = false)]
        public Result[] Results { get; set; }
    }

    [DataContract]
    public class Summary
    {
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string Query { get; set; }
    }

    [DataContract]
    public class Result
    {
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public Position Position { get; set; }

        [DataMember(Name = "address", EmitDefaultValue = false)]
        public Address Address { get; set; }
    }

    [DataContract]
    public class Address
    {
        [DataMember(Name = "freeformAddress", EmitDefaultValue = false)]
        public string FreeformAddress { get; set; }
    }


    [DataContract]
    public class Position
    {
        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public string Latitude { get; set; }

        [DataMember(Name = "lon", EmitDefaultValue = false)]
        public string Longitude { get; set; }
    }
}
