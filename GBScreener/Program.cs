using System.ServiceModel.Syndication;
using System.Xml;
using System;

namespace GBScreener
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://rssfeeds.s3.amazonaws.com/goldbox";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                string subject = item.Title.Text;
                //string summary = item.Summary.Text;
                //Console.WriteLine(subject);
                var links = item.Links;
                var itemUri = links[0].Uri.AbsolutePath;
                Console.WriteLine(itemUri);
            }
            Console.ReadKey();

        }
    }
}
