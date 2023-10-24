using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaveStuff
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Title = "Save Stuff";
        }

        void Save_Clicked(System.Object sender, System.EventArgs e)
        {
            Application.Current.Properties["UserName"] = txtUserName.Text;
        }

        void Read_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("UserName"))
            {
                txtUserName.Text = Application.Current.Properties["UserName"].ToString();
            }
            else
            {
                
            }
        }

        void Clear_Clicked(System.Object sender, System.EventArgs e)
        {
            txtUserName.Text = "";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Read_Clicked(null, null);
        }
    }
}
