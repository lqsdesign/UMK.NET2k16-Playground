using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using PSPiZK;

namespace KolokwiumMVVM
{
    public class BeepSound : Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            TextBox window = this.AssociatedObject;
            if (window != null) window.TextChanged += Window_TextChanged;
        }

        private void Window_TextChanged(object sender, TextChangedEventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            Window window = sender as Window;
            SystemSounds.Beep.Play();
        }
    }
}
