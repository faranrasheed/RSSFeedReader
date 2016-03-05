using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RSSFeedReader
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ReaderLibrary Library = new ReaderLibrary();

        String feedURL = "http://www.feedforall.com/sample.xml";

        public MainPage()
        {
            this.InitializeComponent();
            Library.Go(ref FeedResults, feedURL);
        }
    }
}
