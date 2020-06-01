using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace XAML2
{
    /// <summary>
    /// Logique d'interaction pour MBPerso.xaml
    /// </summary>
    public partial class MBPerso : Window
    {
        public MBPerso(string message, MessageButtons Buttons)
        {
            InitializeComponent();
            MessageAffiche.Text = message;
            switch (Buttons)
            {
                case MessageButtons.OkCancel:
                    btnOui.Visibility = Visibility.Collapsed; btnNon.Visibility = Visibility.Collapsed;
                    break;
                case MessageButtons.YesNo:
                    btnOk.Visibility = Visibility.Collapsed; btnAnnuler.Visibility = Visibility.Collapsed;
                    break;
                case MessageButtons.Ok:
                    btnOk.Visibility = Visibility.Visible;
                    btnAnnuler.Visibility = Visibility.Collapsed;
                    btnOui.Visibility = Visibility.Collapsed; btnNon.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnOui_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnNon_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
    public enum MessageButtons
    {
        OkCancel,
        YesNo,
        Ok,
    }
}
