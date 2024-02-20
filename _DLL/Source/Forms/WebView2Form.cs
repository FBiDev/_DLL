using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Web.WebView2.Core;
using GNX;
using GNX.Desktop;

namespace _DLL
{
    public partial class WebView2Form : Form
    {
        public WebView2Form()
        {
            InitializeComponent();
            Shown += Form1_Shown;

            SetProxy();
            //SetCookies();

            wbvMain.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            wbvMain.NavigationCompleted += webView21_NavigationCompleted;
        }

        public const string HOST_URL = "https://retroachievements.org/";
        public const string LOGIN_URL = HOST_URL + "login";

        void Form1_Shown(object sender, EventArgs e)
        {
            wbvMain.Source = new Uri(LOGIN_URL);
        }

        void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        { }

        async void webView21_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            string webViewHtml = await wbvMain.ExecuteScriptAsync("document.documentElement.outerHTML");
            var htmldecoded = JsonConvert.DeserializeObject(webViewHtml).ToString();

            var login = htmldecoded.GetBetween("<form action=\"https://retroachievements.org/", "\"");

            if (login != "login") return;
        }

        public async static void SetCookies()
        {
            var cookieReader = new ChromiumCookieReader();
            var cookies = cookieReader.GetCookies("retroachievements.org", @"AppTest.vshost.exe.WebView2\EBWebView");

            var w = new WebClientExtend();
            foreach (var c in cookies)
            {
                w.CookieContainer.Add(c);
            }

            w.Proxy = Browser.DefaultProxy;
            var html = await w.DownloadString(LOGIN_URL);
            var html2 = await w.DownloadString(LOGIN_URL);
        }

        public static void SetProxy()
        {
            //Environment.SetEnvironmentVariable("WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS", "--proxy-server=\"http://fbirnfeld:zumbie@cohab-proxy.cohabct.com.br:3128\"");
            Browser.UseProxy = Environment.MachineName.Equals("COHAB-CT0920");
            Browser.DefaultProxy = new WebProxy
            {
                Address = new Uri("http://cohab-proxy.cohabct.com.br:3128"),
                BypassProxyOnLocal = true,
                BypassList = new string[] { },
                Credentials = new NetworkCredential("fbirnfeld", "zumbie")
            };
        }
    }
}