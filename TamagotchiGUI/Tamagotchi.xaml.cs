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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tamagotchi;

namespace TamagotchiGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TamagotchiObject to = new TamagotchiObject();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {            
            to.Tick();
            MessageBox.Show(to.activity("play"));
        }

        private void FeedButton_Click(object sender, RoutedEventArgs e)
        {
            to.Tick();
            MessageBox.Show(to.activity("feed"));
        }

        private void SleepButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(to.activity("sleep"));
            to.Tick();
        }

        private void PoopButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(to.activity("poop"));
            to.Tick();
        }
    }
}
