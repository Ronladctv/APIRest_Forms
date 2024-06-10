using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace APIRest_Forms.Model
{
    public partial class MainPage : ContentPage
    { 
        private const string Url = "http://jsonplaceholder.typicode.com/posts";
        private readonly HttpClient client = new HttpClient();
    }
}
