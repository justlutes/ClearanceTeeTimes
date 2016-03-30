using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ClearanceTeeTimes.Mobile
{
    public class BaseViewModel : ContentView
    {
        public BaseViewModel()
        {
            Content = new Label { Text = "Hello ContentView" };
        }
    }
}
