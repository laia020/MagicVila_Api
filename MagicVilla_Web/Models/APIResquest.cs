using Microsoft.AspNetCore.Mvc;
using static MagicVilla_Utility.SD;

namespace MagicVilla_Web.Models
{
    public class APIResquest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        
    }
}
