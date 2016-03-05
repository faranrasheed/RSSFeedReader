using System;
using Windows.UI.Xaml.Controls;
using Windows.Web.Syndication;

public class ReaderLibrary
{
    private async void load(ItemsControl list, Uri uri)
    {
        SyndicationClient client = new SyndicationClient();
        SyndicationFeed feed = await client.RetrieveFeedAsync(uri);
        if (feed != null)
        {
            foreach (SyndicationItem item in feed.Items)
            {
                list.Items.Add(item);
            }
        }
    }

    public void Go(ref ItemsControl list, string value)
    {
        load(list, new Uri(value));
    }
}