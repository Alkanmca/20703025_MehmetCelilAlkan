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

namespace deneme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + "                             " + textBox2.Text + "                             " + textBox3.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.Items.IndexOf(listBox1.SelectedItem));
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int i;
            if (!int.TryParse(textBox3.Text, out i))
            {
                MessageBox.Show("Sayı Girin!");
                return;
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, textBox4.Text);
            }
            textBox4.Clear();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                textBox4.Text = listBox1.SelectedItem.ToString();
            }
        }


    }
}
