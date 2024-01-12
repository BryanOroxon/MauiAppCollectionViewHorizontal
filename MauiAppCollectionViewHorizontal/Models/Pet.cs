using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MauiAppCollectionViewHorizontal.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Breed { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
        public string Gender { get; set; }
        public string Health { get; set; }
        public string Meet { get; set; }
        public string Social { get; set; }
        public string Url { get; set; }
    }

    [JsonSerializable(typeof(List<Pet>))]
    internal sealed partial class PetContext : JsonSerializerContext
    {

    }
}
