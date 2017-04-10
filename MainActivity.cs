using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Webkit;
using System.Net;

namespace Stackapps_Development
{
    [Activity(Label = "Stackapps_Development", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
         
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);



            WebView localWebView = FindViewById<WebView>(Resource.Id.LocalWebView);
            localWebView.SetWebViewClient(new WebViewClient()); // stops request going to Web Browser
            localWebView.LoadData("<div class='separator' style='clear: both; text-align: center;'><a href = 'https://lh3.googleusercontent.com/-JdSaOMMseKg/WM_9Lh8k5tI/AAAAAAAAABU/opJXXVB_Y_U/s1600/images-32.jpeg' imageanchor='1' style='margin-left: 1em; margin-right: 1em;'> <img border = '0' src='https://lh3.googleusercontent.com/-JdSaOMMseKg/WM_9Lh8k5tI/AAAAAAAAABU/opJXXVB_Y_U/s640/images-32.jpeg'></a></div>", "text/html; charset=UTF-8", null);
            



        }
    }


}


//using System;
//using System.Net.Http;
//using Android.App;
//using Android.OS;
//using Newtonsoft.Json;



//namespace Stackapps_Development
//{
//    [Activity(Label = "Stackapps_Development", MainLauncher = true, Icon = "@drawable/icon")]
//    public class MainActivity : Activity
//    {

//        protected override void OnCreate(Bundle bundle)
//        {
//            base.OnCreate(bundle);
//            SetContentView(Resource.Layout.Main);
//            GetDetail("1");

//        }

//        public class Detail
//        {
//            public string ArticleDetail
//            {
//                get;
//                set;
//            }
//        }

//        public async void GetDetail(string id)
//        {
//            HttpClient client = new HttpClient();
//            var RestURL = "";
//            client.BaseAddress = new Uri(RestURL);
//            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
//            HttpResponseMessage response = await client.GetAsync(RestURL);
//            HttpContent _Hcontent = response.Content;
//            var result = await _Hcontent.ReadAsStringAsync();
//            var Items = JsonConvert.DeserializeObject<Detail>(result);
//            articleweb.Source = new HtmlWebViewSource
//            {
//                Html = Items.ArticleDetail
//            };
//        }
//    }
//}  



//using Android.App;
//using Android.OS;

//namespace Stackapps_Development
//{
//    [Activity(Label = "Stackapps_Development", MainLauncher = true, Icon = "@drawable/icon")]
//    public class MainActivity : Activity
//    {

//        protected override void OnCreate(Bundle bundle)
//        {
//            base.OnCreate(bundle);
//            SetContentView(Resource.Layout.Main);

//        }

//    }


//}



//localWebView.LoadUrl("http://crawl-db.blogspot.in");

