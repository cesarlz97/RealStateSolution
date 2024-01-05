using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models.TwitterAPI
{
    public class Media
    {
        public List<string> media_ids { get; set; }

        public Media(List<string> media_ids)
        {
            this.media_ids = media_ids;
        }
    }

    public class TwitterPublishTweetRequest
    {
        public string text { get; set; }
        public Media media { get; set; }

        public TwitterPublishTweetRequest(string text, List<string> media_ids)
        {
            this.text = text;
            media = new Media(media_ids);
        }
    }
}
