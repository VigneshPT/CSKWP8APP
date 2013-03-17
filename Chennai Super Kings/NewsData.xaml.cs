using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Chennai_Super_Kings
{
    public partial class NewsData : PhoneApplicationPage
    {
        public NewsData()
        {
            InitializeComponent();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            title.Text = LatestNews.ittitle;
            cont.Text = LatestNews.itcontent;
        }


    }
}