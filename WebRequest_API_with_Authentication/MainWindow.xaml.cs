using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharp_Samples
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/system.net.httpwebrequest.getresponse?view=netcore-3.1    WEBSITE API RESPONSE
    /// https://stackoverflow.com/questions/25852551/how-to-add-basic-authentication-header-to-webrequest     ADDING AUTHENTICATION HEADERS


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            getAPI_ResponseWithAuthentication();
        }
        public void getAPI_ResponseWithAuthentication()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.twitch.tv/helix/users?login=" + "pow3rtv");
            // Set some reasonable limits on resources used by this request
            request.Headers.Add("Client-ID", "la81ubesu8iud3aeckoekrd733apij");
            request.Headers.Add("Authorization", "Bearer um48yvg9ezylg28i4sa5kbxseecgx6");
            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            Console.WriteLine("Content length is {0}", response.ContentLength);
            Console.WriteLine("Content type is {0}", response.ContentType);

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format.
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Console.WriteLine("Response stream received.");
            var answer = readStream.ReadToEnd();
            WebResponseAPI.Text = answer;
            Console.WriteLine(answer);
            response.Close();
            readStream.Close();
        }

        public void getAPI_ResponseWithoutAuthentication()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.twitch.tv/helix/users?login=" + "pow3rtv");
            // Set some reasonable limits on resources used by this request
            request.MaximumAutomaticRedirections = 4;
            request.MaximumResponseHeadersLength = 4;
            // Set credentials to use for this request.
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine("Content length is {0}", response.ContentLength);
            Console.WriteLine("Content type is {0}", response.ContentType);

            // Get the stream associated with the response.
            Stream receiveStream = response.GetResponseStream();

            // Pipes the stream to a higher level stream reader with the required encoding format.
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            Console.WriteLine("Response stream received.");
            var answer = readStream.ReadToEnd();
            WebResponseAPI.Text = answer;
            Console.WriteLine(answer);
            response.Close();
            readStream.Close();
        }
    }
}