using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organism_Simulation
{
    public partial class Inspector : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        public System.Timers.Timer simtimer;
        float update_speed = Data.def_simspeed;


        public List<Organism> orgs;
        public Inspector(List<Organism> org, System.Timers.Timer time)
        {
            orgs = org;
            simtimer = time;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inspector_Load(object sender, EventArgs e)
        {

           // MessageBox.Show(orgs.Count.ToString());
            timer.Interval = update_speed * Data.insp_speedmul; // ~60 FPS (1000ms / 60)
            timer.Elapsed += (s, e) => Loop();
            timer.Start();
            textBox1.Text = "1";
            inspuf.Text = "100";

        }

        public void Loop()
        {
            //  if (listBox1.SelectedIndex != -1)
            //{
            //  orgs[listBox1.SelectedIndex].selected = true;


            //     }

            Invalidate();
            orgno.Text = "Total No. of Organisms: " + orgs.Count.ToString();

            listBox1.Items.Clear();
            foreach (Organism org in orgs)
            {

                string x = "Position: " + org.position.ToString() + "; " +
                           "Energy: " + org.energy.ToString() + "; " +
                 "Idle EU: " + org.idle_eu.ToString() + "; " +
                             "Move EU: " + org.move_eu.ToString() + "; " +
                           "Sense Size: " + org.sense_size.ToString() + "; " +
                             "Speed: " + org.speed.ToString() + "; " +
                     "Dead: " + org.dead.ToString() + "; " +
                     "Selected: " + org.selected.ToString() + "; ";
                listBox1.Items.Add(x);
            }
            // listBox1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.insp_speedmul = Convert.ToInt32(inspuf.Text);
            timer.AutoReset = true;
            update_speed = (float)Convert.ToDouble(textBox1.Text);
            timer.Interval = update_speed * Data.insp_speedmul;

            simtimer.AutoReset = true;
            //update_speed = Convert.ToInt32(textBox1.Text);
            simtimer.Interval = update_speed;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer.AutoReset = false;
            simtimer.AutoReset = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer.AutoReset == false && simtimer.AutoReset == false)
            {
                timer.Start();
                simtimer.Start();
            }

        }

        private void modprop_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                orgs[listBox1.SelectedIndex].sense_size = 100;
                orgs[listBox1.SelectedIndex].sense = new Rectangle(orgs[listBox1.SelectedIndex].position.X - 25, orgs[listBox1.SelectedIndex].position.Y - 30, orgs[listBox1.SelectedIndex].sense_size, orgs[listBox1.SelectedIndex].sense_size);

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            /*   var x = 30;
               foreach (Organism org in orgs)
               {


                   e.Graphics.DrawString("Position: " + org.position.ToString() + "; " +
                                           "Energy: " + org.energy.ToString() + "; " +
                                           "Idle EU: " + org.idle_eu.ToString() + "; " +
                                           "Move EU: " + org.move_eu.ToString() + "; " +
                                           "Sense Size: " + org.sense_size.ToString() + "; " +
                                           "Speed: " + org.speed.ToString() + "; " +
                                           "Dead: " + org.dead.ToString() + "; ",
                                       new Font("Arial", 11),
                                       Brushes.Black,
                                       new PointF(15, x += 20));


               }
             */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inspuf_TextChanged(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                orgs[listBox1.SelectedIndex].selected = true;

            }
        }

        private void deselct_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                orgs[listBox1.SelectedIndex].selected = false;

            }
        }
    }
}
