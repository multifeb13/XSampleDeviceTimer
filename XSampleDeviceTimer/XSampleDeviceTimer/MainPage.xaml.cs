using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XSampleDeviceTimer
{
    public partial class MainPage : ContentPage
    {
        private uint TimerCount;
 
        public MainPage()
        {
            InitializeComponent( );

            btnTimer.Clicked += ( sender, e ) =>
            {
                btnTimer.IsEnabled = false;

                Device.StartTimer(
                    TimeSpan.FromSeconds( 1 ),
                    () =>
                    {
                        TimerCount++;
                        this.lblCount.Text = $"{TimerCount}";

                        if( TimerCount >= 10 )
                        {
                            btnTimer.IsEnabled = true;
                            TimerCount = 0;
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                );
            };
        }
    }
}
