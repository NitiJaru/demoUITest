using System;
using System.Collections.Generic;
using System.Text;

namespace demoUITest.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Webview
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
