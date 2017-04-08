using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;
using System.Windows.Input;

namespace PasekPostępuSuwak
{
    public class PressKeyBehavior : Behavior<Slider>
    {
        protected override void OnAttached()
        {
            Slider slider = this.AssociatedObject;
            if (slider != null) slider.KeyDown += AssociatedObject_KeyDown;
        }

        private void AssociatedObject_KeyDown(object s, KeyEventArgs e)
        {
            Slider mySlider = s as Slider;
            
            
            //mySlider.Value = 50;
        }

    }
}
