namespace Race
{
    public class MovingCar
    {
        public PictureBox Car { get; set; }
        public int IncreaseSpeed { get; set; } = 0;
        private Form _form;
        private Random _random = new Random();

        public MovingCar(Form form, PictureBox car)
        {
            _form = form;
            Car = car;
            IncreaseSpeed = _random.Next(0, 5);
        }

        public void Move(int baseSpeed, int formHeight, int formWidth)
        {
            Car.Top += baseSpeed + IncreaseSpeed;

            if (Car.Top > formHeight)
            {
                Car.Top = -Car.Height;
                Car.Left = _random.Next(0, formWidth - Car.Width);
            }
        }
    }
}