using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimpleUITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                //return ConfigureApp.Android.StartApp();

                return ConfigureApp.Android
                                   //.ApkFile("../../../demoUITest/demoUITest/demoUITest.Android/bin/Debug/com.companyname.demoUITest.apk")
                                   //.InstalledApp("com.companyname.demoUITest")
                                   .ApkFile(@"C:\Users\earnd\source\repos\demoUITest\demoUITest\demoUITest.Android\bin\Debug\com.companyname.demoUITest.apk")
                                   //.DeviceSerial("21e2d61e")
                                   .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}