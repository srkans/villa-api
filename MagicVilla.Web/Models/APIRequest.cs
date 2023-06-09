using Microsoft.AspNetCore.Mvc;
using static MagicVilla.Utility.StaticDetails;

namespace MagicVilla.Web.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }

    }
}
