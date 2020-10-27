using Newtonsoft.Json;
using PropertyChanged;
using System;

namespace Notes.API.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Note
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("addDate")]
        public DateTime AddDate { get; set; }
    }
}
