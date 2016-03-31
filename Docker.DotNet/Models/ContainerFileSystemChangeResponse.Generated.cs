using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class ContainerFileSystemChangeResponse // (types.ContainerChange)
    {
        [DataMember(Name = "Kind")]
        public int Kind { get; set; }

        [DataMember(Name = "Path")]
        public string Path { get; set; }
    }
}
