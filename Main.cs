using Android.App;
using Android.OS;
using Android.Webkit;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace StackDEV
{
    [Activity(Label = "StackDEV", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            List<string> list = new List<string>();
            using (WebClient client = new WebClient())
            {
                //client.QueryString.Add("p", "1500"); //add parameters
                string htmlCode = client.DownloadString("http://crawl-db.blogspot.in/");
                string[] delimiters = new string[] { "post-body entry-content" };
                string[] parts = htmlCode.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                //string[] delimiters = new string[] { "itemprop='description articleBody'>" };
                //string[] parts = htmlCode.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (var i = 1; i < parts.Count(); i++)
                {
                    string[] delimiter = new string[] { "<div class='post-footer'>" };
                    string[] parts1 = parts[i].Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    list.Add("<div class='post-body entry-content'" + parts1[0]);
                }


            }


            WebView localWebView = FindViewById<WebView>(Resource.Id.LocalWebView);
            localWebView.SetWebViewClient(new WebViewClient());
            localWebView.LoadData(list[0], "text/html; charset=UTF-8", null);
        }
    }
}

//localWebView.LoadData("<div class='separator' style='clear: both; text-align: center;'><a href = 'https://2.bp.blogspot.com/-V_KARNCt0wM/WLpzXaNLfcI/AAAAAAAAAAY/cR8jOA5qDBUuq5MF1J31HaT_bSYBWZ5yQCLcB/s1600/download-nature-wallpaper.jpg' imageanchor='1' style='margin-left: 1em; margin-right: 1em;'><img border = '0' height='180' src='https://2.bp.blogspot.com/-V_KARNCt0wM/WLpzXaNLfcI/AAAAAAAAAAY/cR8jOA5qDBUuq5MF1J31HaT_bSYBWZ5yQCLcB/s320/download-nature-wallpaper.jpg' width='320'></a></div>", "text/html; charset=UTF-8", null);
