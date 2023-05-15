namespace Lotniska
{
    public partial class Form1 : Form
    {
        Class1 load;
        public List<Class1> list = new List<Class1>();
        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Read_From_CSV();

        }

        public void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Read_From_CSV()
        {
            var lines = File.ReadAllLines(@"Dane testowe.csv");
            foreach (var line in lines)
            {

                var cell = line.Split(" ,");
                load = new Class1() { city = cell[0], district = cell[1], ICAO = cell[2], IATA = cell[3], name = cell[4], number_of_passengers = cell[5], change = cell[6] };
                if (line != lines[0])
                {
                    comboBox1.Items.Add(load.name);
                    //var load2 = new Class2() { city = cell[0], district = cell[1], ICAO = cell[2], IATA = cell[3], name = cell[4], number_of_passengers = cell[5], change = cell[6] };
                    list.Add(load);
                }
                else
                {
                    checkBox1.Text = load.city;
                    checkBox2.Text = load.district;
                    checkBox3.Text = load.ICAO;
                    checkBox4.Text = load.IATA;
                    checkBox5.Text = load.number_of_passengers;
                    checkBox6.Text = load.change;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}