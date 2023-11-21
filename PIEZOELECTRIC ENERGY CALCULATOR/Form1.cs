namespace PIEZOELECTRIC_ENERGY_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double g = 9.8;
        double height = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "15-30")
            {

                double NoP = double.Parse(textBox1.Text);

                double ClassBoundaries = ((14.5 + 30.5) / 2);

                double TotalWeight = NoP * ClassBoundaries;

                textBox2.Text = TotalWeight.ToString() + " " + "m";


                double PotentialEnergy = TotalWeight * g * height;
                textBox3.Text = PotentialEnergy.ToString() + " " + "J";

                double EnergyHarvested = PotentialEnergy * 0.5;
                textBox4.Text = EnergyHarvested.ToString() + " " + "J";

            }
            else if (comboBox1.Text == "31-60")
            {
                double NoP = double.Parse(textBox1.Text);

                double ClassBoundaries = ((30.5 + 60.5) / 2);

                double TotalWeight = NoP * ClassBoundaries;

                textBox2.Text = TotalWeight.ToString() + " " + "m";


                double PotentialEnergy = TotalWeight * g * height;
                textBox3.Text = PotentialEnergy.ToString() + " " + "J";

                double EnergyHarvested = PotentialEnergy * 0.5;
                textBox4.Text = EnergyHarvested.ToString() + " " + "J";

            }
            else if (comboBox1.Text == "61-90")
            {
                double NoP = double.Parse(textBox1.Text);

                double ClassBoundaries = ((60.5 + 90.5) / 2);

                double TotalWeight = NoP * ClassBoundaries;

                textBox2.Text = TotalWeight.ToString() + " " + "m";


                double PotentialEnergy = TotalWeight * g * height;
                textBox3.Text = PotentialEnergy.ToString() + " " + "J";

                double EnergyHarvested = PotentialEnergy * 0.5;
                textBox4.Text = EnergyHarvested.ToString() + " " + "J";

            }
            else if (comboBox1.Text == "91-120")
            {

                double NoP = double.Parse(textBox1.Text);

                double ClassBoundaries = ((90.5 + 120.5) / 2);

                double TotalWeight = NoP * ClassBoundaries;

                textBox2.Text = TotalWeight.ToString() + " " + "m";


                double PotentialEnergy = TotalWeight * g * height;
                textBox3.Text = PotentialEnergy.ToString() + " " + "J";

                double EnergyHarvested = PotentialEnergy * 0.5;
                textBox4.Text = EnergyHarvested.ToString() + " " + "J";
            }
            else
            {
                label7.Text = "Error.!! Please fill in all fields!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }
    }
}