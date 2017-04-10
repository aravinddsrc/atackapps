using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {



            using (WebClient client = new WebClient())
            {
                //client.QueryString.Add("p", "1500"); //add parameters
                string htmlCode = client.DownloadString("http://crawl-db.blogspot.in/");




                string[] delimiters = new string[] { "post-body entry-content" };
                string[] parts = htmlCode.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);


                //string[] delimiters = new string[] { "itemprop='description articleBody'>" };
                //string[] parts = htmlCode.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                List<string> list = new List<string>();
               

                for (var i = 1; i < parts.Count(); i++)
                {
                    string[] delimiter = new string[] { "<div class='post-footer'>" };
                    string[] parts1 = parts[i].Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    list.Add("<div class='post-body entry-content'" + parts1[0]);
                }

             
            }


        }
    }
}
