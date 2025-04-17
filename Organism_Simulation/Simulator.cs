namespace Organism_Simulation
{
    public partial class Simulator : Form
    {
        public List<Point> foodloc;
        public List<Organism> organisms;
      
        System.Timers.Timer timer = new System.Timers.Timer();
       
        Random rand = new Random();
        float sim_speed = Data.def_simspeed;
        Inspector inspector;


        public Point MoveTowards(Point current, Point target, float speed)
        {
            float dx = target.X - current.X;
            float dy = target.Y - current.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance <= speed || distance == 0)
                return target; // Snap to target when close enough

            float nx = dx / distance;
            float ny = dy / distance;

            int newX = (int)(current.X + nx * speed);
            int newY = (int)(current.Y + ny * speed);

            return new Point(newX, newY);
        }




        public Simulator()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // Make sure the form captures key events
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);


            organisms = new List<Organism>();
            int organismcnt = rand.Next(1, 21);
            for(int i = 0; i < organismcnt; i++)
            {
                Organism or = new Organism();
                or.position = new Point(rand.Next(15, this.ClientSize.Width - 15), rand.Next(15, this.ClientSize.Height - 15));
                or.sense_size = Data.def_size;
                or.sense = new Rectangle(or.position.X - 25, or.position.Y - 30, or.sense_size, or.sense_size);
                or.speed = Data.def_speed;
                or.energy = Data.def_energy;
                or.idle_eu = Data.def_idle_eu;
                or.move_eu = Data.def_move_eu;
                or.dead = false;

                organisms.Add(or);
            }


           // Organism or = new Organism();
            

            


            inspector = new Inspector(organisms,timer);
            inspector.Show();
            foodloc = new List<Point>();
            int foodcount = rand.Next(30, 90);
            for (int i = 0; i< foodcount; i++)
            {
                foodloc.Add(new Point(rand.Next(15,this.ClientSize.Width-15),rand.Next(15,this.ClientSize.Height-15)));
            }
            
            timer.Interval = sim_speed; // ~60 FPS (1000ms / 60)
            timer.Elapsed += (s, e) => Loop();
            timer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            


            foreach (Organism organism in organisms) 
            {
               

                if (organism.dead == true)
                {
                    g.FillEllipse(Brushes.Red, (organism.position.X - 5), (organism.position.Y - 5), 20, 20);

                    // Draw sensing area
                    g.DrawRectangle(Pens.Yellow, organism.sense);
                }
                else if (organism.selected == true)
                {
                    g.FillEllipse(Brushes.LimeGreen, (organism.position.X - 5), (organism.position.Y - 5), 20, 20);

                    // Draw sensing area
                    g.DrawRectangle(Pens.Cyan, organism.sense);
                }
                else
                {
                    // Draw self (organism)
                    g.FillEllipse(Brushes.Blue, (organism.position.X - 5), (organism.position.Y - 5), 20, 20);

                    // Draw sensing area
                    g.DrawRectangle(Pens.Red, organism.sense);
                }

               
            }
            // Draw food locations
            foreach (Point food in foodloc.ToList())
            {
                g.FillEllipse(Brushes.Green, food.X - 3, food.Y - 3, 10,10);
            }
        }


        public void Loop()
        {
            foreach (Organism organism in organisms)
            {
                if (organism.dead == false)
                {
                    if (foodloc.Count > 0)
                    {
                        foreach (Point food in foodloc.ToList())
                        {
                            if (organism.sense.Contains(food))
                            {
                                organism.position = MoveTowards(organism.position, food, organism.speed);
                                organism.energy -= organism.move_eu;
                                if (organism.position == food)
                                {
                                    foodloc.Remove(food);
                                    int foodenergylevel = rand.Next(40, 300);
                                    organism.energy += foodenergylevel;
                                    

                                }

                            }


                        }


                        int dir = rand.Next(1, 5); // Use 1-4 to avoid "0" doing nothing

                        switch (dir)
                        {
                            case 1: // Move Down
                                if (organism.position.Y + 1 < ClientSize.Height - 15)
                                    organism.position.Y += organism.speed * 2;
                                organism.energy -= organism.move_eu;
                                break;

                            case 2: // Move Up
                                if (organism.position.Y - 1 > 15)
                                    organism.position.Y -= organism.speed * 2;
                                organism.energy -= organism.move_eu;
                                break;

                            case 3: // Move Right
                                if (organism.position.X + 1 < ClientSize.Width - 15)
                                    organism.position.X += organism.speed * 2;
                                organism.energy -= organism.move_eu;
                                break;

                            case 4: // Move Left
                                if (organism.position.X - 1 > 15)
                                    organism.position.X -= organism.speed * 2;
                                organism.energy -= organism.move_eu;
                                break;
                        }



                    }

                    organism.energy -= organism.idle_eu;
                    if (organism.energy <= 0)
                    {
                        // MessageBox.Show("dead");
                        //  Application.Exit();
                        organism.dead = true;
                    }

                    organism.sense = new Rectangle(organism.position.X - 25, organism.position.Y - 30, organism.sense_size, organism.sense_size);
                }
                else if(organism.dead == true)
                {
                    organisms.Remove(organism);
                }
            }
            Refresh();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check for the combination of Ctrl+key
            if (e.Control)
            {
                // Ctrl + C (Copy)
                if (e.KeyCode == Keys.I)
                {
                   inspector.Close();
                   inspector = new Inspector(organisms,timer);
                   inspector.Show();
                }
                // Ctrl + V (Paste)
                else if (e.KeyCode == Keys.A)
                {
                    MessageBox.Show("Simple Organism Simulation", "© Thor 267");
                }
            }
        }

    }   
}
