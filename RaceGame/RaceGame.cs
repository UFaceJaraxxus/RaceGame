namespace Race
{
	public partial class RaceGame : Form
	{
        private int _score = 0;
        private int _coinsCount = 0;
        private int _carSpeed = 2;

		private PictureBox[] _coins = new PictureBox[3];

        private Label[] _gameLines = new Label[10];
		private MovingCar[] _gameCars = new MovingCar[3];
        private Road _gameRoad;

        private Label[] _menuLanes = new Label[10];
        private MovingCar[] _menuCars = new MovingCar[3];
        private Road _menuRoad;

        private Random _random = new Random();

        public RaceGame()
        {
            InitializeComponent();
        }

        private void RaceGameLoad(object sender, EventArgs e)
        {
            _coins = new[] { Coin1, Coin2, Coin3 };

            _gameLines = new[] { LaneOne1, LaneOne2, LaneOne3, LaneOne4, LaneOne5, LaneTwo1, LaneTwo2, LaneTwo3, LaneTwo4, LaneTwo5 };
            _gameCars = new MovingCar[] { new MovingCar(this, towardCar1), new MovingCar(this, towardCar2), new MovingCar(this, towardCar3) };
            _gameRoad = new Road(this, _gameLines, _gameCars, _carSpeed);

            _menuLanes = new[] { MenuOneLane1, MenuOneLane2, MenuOneLane3, MenuOneLane4, MenuOneLane5, MenuTwoLane1, MenuTwoLane2, MenuTwoLane3, MenuTwoLane4, MenuTwoLane5 };
            _menuCars = new MovingCar[] { new MovingCar(this, CarMenu1), new MovingCar(this, CarMenu2), new MovingCar(this, CarMenu3) };
            _menuRoad = new Road(this, _menuLanes, _menuCars, _carSpeed);

            timerRoad.Stop();
            timerTowardCars.Stop();
            panelMenu.Show();
        }

        private void TimerRoadTick(object sender, EventArgs e)
		{
			labelScore.Text = "Score: " + _score / 10;
            _gameRoad.Speed = _carSpeed;

            _gameRoad.Refresh();

            if (_carSpeed != 0)
            {
                _score++;
            }

			foreach (var coin in _coins)
			{
				coin.Top += _carSpeed;

				if (coin.Top > Height)
				{
					GenerateCoin(coin);
				}
			}

            CollectCoins();
		}

        private void TimerTowardCarsTick(object sender, EventArgs e)
        {
            foreach (var towardCar in _gameCars)
            {
                towardCar.Car.Top += _carSpeed + towardCar.IncreaseSpeed;

                if (towardCar.Car.Top > Height)
                {
                    RespawnCar(towardCar, _gameCars);
                }

                if (mainCar.Bounds.IntersectsWith(towardCar.Car.Bounds))
                {
                    GameOver();
                }                    
            }
        }

        private void TimerMenuTick(object sender, EventArgs e)
        {
            _menuRoad.Refresh();

            foreach (var car in _menuCars)
            {
                car.Car.Top += 2;

                if (car.Car.Top > Height)
                {
                    car.Car.Top = -car.Car.Height;
                    car.Car.Left = _random.Next(0, Width - car.Car.Width);
                }
            }
        }

        private void RaceGameKeyDown(object sender, KeyEventArgs e)
        {
            int maxSpeed = 21;
            int moveStep = 9;

            if (_carSpeed != 0)
            {
                if (e.KeyCode == Keys.D && mainCar.Right < this.ClientSize.Width)
                {
                    mainCar.Left += moveStep;
                }
                else if (e.KeyCode == Keys.A && mainCar.Left > 0)
                {
                    mainCar.Left -= moveStep;
                }
            }

            if (e.KeyCode == Keys.W && _carSpeed < maxSpeed)
            {
                _carSpeed++;
            }
            else if (e.KeyCode == Keys.S && _carSpeed > 0)
            {
                _carSpeed--;
            }

            if (e.KeyCode == Keys.Escape)
            {
                timerRoad.Enabled = false;
                timerTowardCars.Enabled = false;
                panelPause.Show();
            }
        }

        void CollectCoins()
		{
			foreach (var coin in _coins)
			{
				if (mainCar.Bounds.IntersectsWith(coin.Bounds))
				{
					_coinsCount++;
                    labelCoins.Text = "Coins: " + _coinsCount;
					GenerateCoin(coin);
                }
			}
		}

        private void GameOver()
		{
            int coinsToContinue = 15;

            timerRoad.Stop();
			timerTowardCars.Stop();

			if (_coinsCount < coinsToContinue)
			{
				DialogResult dd = MessageBox.Show("Game Over!", "Приехали!");
				panelPause.Show();
				panelMenu.Show();
			}
			else
			{
				DialogResult dr = MessageBox.Show("Продолжить? (-15 coins)", "Приехали!",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dr == DialogResult.Yes)
                {
                    Restart();
                }
                else if (dr == DialogResult.No)
                {
                    panelPause.Show();
                    panelMenu.Show();
                }
			}
		}

        private void StartGame()
        {
            _score = 0;
            _coinsCount = 0;
            labelCoins.Text = "Coins: " + _coinsCount;
            _carSpeed = 2;
            timerRoad.Start();
            timerTowardCars.Start();
            GenerateCars(_gameCars);
            panelGame.Show();
            panelPause.Hide();
            panelMenu.Hide();
        }

        private void Restart()
		{
			_coinsCount -= 15;
			labelCoins.Text = "Coins: " + _coinsCount;
			_carSpeed = 2;
			timerRoad.Start();
			timerTowardCars.Start();
            GenerateCars(_gameCars);
        }

		private void ButtonPauseClick(object sender, EventArgs e)
		{

			timerRoad.Enabled = false;
			timerTowardCars.Enabled = false;
			panelPause.Show();
		}

        private void ButtonStartClick(object sender, EventArgs e)
        {
            StartGame();
        }

        private void ButtonResumeClick(object sender, EventArgs e)
		{
			timerRoad.Enabled = true;
			timerTowardCars.Enabled = true;
			panelPause.Hide();
		}

		private void ButtonExitClick(object sender, EventArgs e)
		{
			panelMenu.Show();
		}

		private void ButtonHelpClick(object sender, EventArgs e)
		{
            string helpPath = Path.Combine(Application.StartupPath, "help.chm");
            Help.ShowHelp(this, helpPath, HelpNavigator.TableOfContents);
        }

		private void ButtonMenuExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void GenerateCoin(PictureBox coin)
		{
                coin.Top = -coin.Height;
                coin.Left = _random.Next(0, Width - coin.Width);
        }

        private void GenerateCars(MovingCar[] cars)
        {
            foreach (var car in cars)
            {
                RespawnCar(car, cars);
            }
        }

        private void RespawnCar(MovingCar car, MovingCar[] allCars)
        {
            bool isPlaceFree = false;

            while (!isPlaceFree)
            {
                int newTop = _random.Next(-300, -100);
                int newLeft = _random.Next(0, Width - car.Car.Width);

                Rectangle testBounds = new Rectangle(newLeft, newTop, car.Car.Width, car.Car.Height);
                isPlaceFree = true;

                foreach (var other in allCars)
                {
                    if (other == car)
                    {
                        continue;
                    }

                    if (testBounds.IntersectsWith(other.Car.Bounds))
                    {
                        isPlaceFree = false;
                        break;
                    }
                }

                if (isPlaceFree)
                {
                    car.Car.Top = newTop;
                    car.Car.Left = newLeft;
                }
            }

            car.IncreaseSpeed = _random.Next(0, 5);
        }
    }
}