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

namespace _2024_exam
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create tickets
            Ticket t1 = new Ticket("Early Bird", 100m, 100);
            Ticket t2 = new Ticket("Platinum Ticket", 150m, 100);
            Ticket t3 = new VIPTicket("Ticket and Hotel Package", 150m, 100, "4 star Hotel", 100m);

            //create list of tickets
            List<Ticket> e1Tickets = new List<Ticket>() { t1, t2, t3 };

            //create event
            Event e1 = new Event()
            {
                Name = "Rock Concert",
                EventDate = new DateTime(2024, 12, 1),
                Tickets = e1Tickets,
                TypeOfEvent = EventType.Music
            };
        }
    }
}
