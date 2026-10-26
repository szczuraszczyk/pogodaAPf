using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace pogodaAPf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            BlockGodzina.Text = DateTime.Now.ToString("HH:mm:ss");
            DateBlock.Text = DateTime.Now.ToString("dddd, d MMMM yyyy");
            BlockGodzinaTokio.Text = DateTime.Now.AddHours(8).ToString("HH:mm:ss");
            DateBlockTokio.Text = DateTime.Now.AddHours(8).ToString("dddd, d MMMM yyyy");
        }

    } 
}
