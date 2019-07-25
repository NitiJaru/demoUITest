using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimpleUITest
{
    public class AppInitializer
    {
        private const string AndroidAPK = @"C:\Users\earnd\source\repos\demoUITest\demoUITest\demoUITest.Android\bin\Debug\com.companyname.demoUITest.apk";
        private const string iOSApp = @"/path/to/iosapp.app";

        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android
                                   .ApkFile(AndroidAPK)
                                   .StartApp();
            }

            return ConfigureApp.iOS
                               .InstalledApp("com.companyname.demoUITest")
                               //.AppBundle(iOSApp)
                               .StartApp(); ;
        }
    }
}