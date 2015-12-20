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
using kursach;

namespace WpfApplication4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public room Room = new room();
        public void drawroom()
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            DrawingContext dc = drawingVisual.RenderOpen();
            dc.DrawRectangle(null, new Pen(Brushes.Black, 1), new Rect(Room.coord[0].x, Room.coord[0].y, Room.coord[1].x, Room.coord[1].y));
            dc.Close();
            image2.Source = new DrawingImage(drawingVisual.Drawing);
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int len=0, wid=0;
            try
            {
                len = int.Parse(((TextBox)Buttons.Children[0]).Text);
                wid = int.Parse(((TextBox)Buttons.Children[1]).Text);
                coordinate lb = new coordinate(10, 10);
                coordinate tr = new coordinate(10 + len, 10 + wid);

                Room.Resize(lb, tr);
                drawroom();
            }
            catch
            {
                MessageBox.Show("Something goes wrong");
            }
        }        
    }
}
