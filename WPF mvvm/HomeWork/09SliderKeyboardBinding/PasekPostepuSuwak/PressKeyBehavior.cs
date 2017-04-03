using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Input;

namespace PasekPostepuSuwak
{
    class PressKeyBehavior : Behavior<Slider>
    {
        protected override void OnAttached()
        {
            Slider slider = this.AssociatedObject;
            if (slider != null) slider += AssociatedObject_KeyDown;
        }

        private void AssociatedObject_KeyDown(object s, KeyEventArgs e)
        {
            Window window = s as Window;
            Slider mySlider = window.FindName("MySlider") as Slider;

            //mySlider.Value = 50;
        }

    }
}
