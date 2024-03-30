using assignment1.Classes;
using assignment1.Interfaces;

namespace assignment1
{
    public partial class Form1 : Form
    {
        private TrainJourney trainJourney;
        private ITrainController trainController;
        public Form1()
        {
            InitializeComponent();

            trainJourney = new TrainJourney();
            trainController = new TrainController(trainJourney);
        }

        private void nextStationButton_Click(object sender, EventArgs e)
        {
            trainController.NextStation();
        }

        private void newDisplayButton_Click(object sender, EventArgs e)
        {
            TrainDisplay trainDisplay = new TrainDisplay(trainJourney);
            trainDisplay.Show();
        }
    }
}