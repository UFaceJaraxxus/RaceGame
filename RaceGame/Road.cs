namespace Race
{
    public class Road
    {
        private Form _form;
        public Label[] Lanes { get; set; }
        public MovingCar[] Cars { get; set; }
        public int Speed { get; set; }

        public Road(Form form, Label[] lanes, MovingCar[] cars, int speed)
        {
            this._form = form;
            Lanes = lanes;
            Cars = cars;
            Speed = speed;
        }

        public void Refresh()
        {
            foreach (var lane in Lanes)
            {
                lane.Top += Speed;

                if (lane.Top > _form.Height)
                {
                    lane.Top = -lane.Height;
                }                    
            }        
        }
    }
}