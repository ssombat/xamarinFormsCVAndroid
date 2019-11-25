using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace collectionviewandroid
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<object> someList = new List<object>();
        public MainPage()
        {
            BindingContext = this;
            for (int i = 0; i < 30; i++)
            {
                someList.Add(new object());
            }
            InitializeComponent();
            myCollectionView.ItemsSource = someList;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            myframe.IsVisible = !myframe.IsVisible;
        }

    }
}
