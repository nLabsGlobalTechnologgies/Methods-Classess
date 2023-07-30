namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Mark = "BMW",
                Model = 2021,
                Color = "Beyaz",
                Speed = 250,
                Motor = 1234.56,
                Status = 'S',
                Money = 500000.00M
            };
            lb1.Text = car.Mark;
            lb2.Text = car.Model.ToString();
            lb3.Text = car.Color;
            lb4.Text = car.Speed.ToString();
            lb5.Text = car.Motor.ToString();
            lb6.Text = car.Status.ToString();
            lb7.Text = car.Money.ToString() + " TL";
            listBox1.Items.Add(car);
        }
    }
}