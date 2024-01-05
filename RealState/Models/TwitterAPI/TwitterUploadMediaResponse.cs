using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models.TwitterAPI
{
    public class TwitterImage
    {
        public string image_type { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class TwitterUploadMediaResponse
    {
        public long media_id { get; set; }
        public string media_id_string { get; set; }
        public string media_key { get; set; }
        public int size { get; set; }
        public int expires_after_secs { get; set; }
        public TwitterImage image { get; set; }
    }
}
