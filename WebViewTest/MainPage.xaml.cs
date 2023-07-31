using System.Net;

namespace WebViewTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        WebViewRenderer();
    }
    private async void WebViewRenderer()
    {
        CookieContainer cookieContainer = new CookieContainer();
        Uri uri = new Uri("https://admin.dev.vstrial.com/", UriKind.RelativeOrAbsolute);

        Cookie cookie = new Cookie
        {
            Name = "userName",
            Value = "ctr",
            Domain = ".vstrial.com",
            Path = "/"
        };

        cookieContainer.Add(uri, cookie);
        cookie = new Cookie
        {
            Name = "role",
            Value = "3",
            Domain = ".vstrial.com",
            Path = "/"
        };
        cookieContainer.Add(uri, cookie);

        cookie = new Cookie
        {
            Name = "lastLogin",
            Value = "2023-07-30T13:23:13.053702Z",
            Domain = ".vstrial.com",
            Path = "/"
        };
        cookieContainer.Add(uri, cookie);
        cookie = new Cookie
        {
            Name = "token",
            Value = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpZCI6Miwic2VjcmV0IjoiYjE4M2ViOWYtYWM1Mi00M2U4LThkNzItOWZmMzRmZjkxNWUyIn0.1_szMsTu5hjgpyTpnDTwTx1biMnioV7H6AMW_Aj7OvM",
            Domain = ".vstrial.com",
            Path = "/"
        };

        cookieContainer.Add(uri, cookie);
        cookie = new Cookie
        {
            Name = "isFormManager",
            Value = "false",
            Domain = ".vstrial.com",
            Path = "/"
        };

        cookieContainer.Add(uri, cookie);
        cookie = new Cookie
        {
            Name = "isSuperUser",
            Value = "true",
            Domain = ".vstrial.com",
            Path = "/"
        };

        cookieContainer.Add(uri, cookie);
        webView.Cookies = cookieContainer;
        webView.HeightRequest = Height;
        webView.Source = new UrlWebViewSource { Url = uri.ToString() };
    }
    private void View_Navigated(object sender, WebNavigatedEventArgs e)
    {
        (sender as WebView).HeightRequest = Height;
    }
}

