namespace Organism_Simulation
{
    partial class ModifyProp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            posx = new TextBox();
            posy = new TextBox();
            sensy = new TextBox();
            sensx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            energy = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            apply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Position:";
            // 
            // posx
            // 
            posx.Location = new Point(16, 41);
            posx.Name = "posx";
            posx.Size = new Size(100, 23);
            posx.TabIndex = 1;
            posx.Text = "X";
            // 
            // posy
            // 
            posy.Location = new Point(122, 41);
            posy.Name = "posy";
            posy.Size = new Size(100, 23);
            posy.TabIndex = 2;
            posy.Text = "Y";
            // 
            // sensy
            // 
            sensy.Location = new Point(122, 101);
            sensy.Name = "sensy";
            sensy.Size = new Size(100, 23);
            sensy.TabIndex = 5;
            // 
            // sensx
            // 
            sensx.Location = new Point(16, 101);
            sensx.Name = "sensx";
            sensx.Size = new Size(100, 23);
            sensx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 78);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Sense Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Move EU:";
            // 
            // energy
            // 
            energy.Location = new Point(16, 170);
            energy.Name = "energy";
            energy.Size = new Size(100, 23);
            energy.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 143);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Idle EU:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 78);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 10;
            label5.Text = "Energy:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 208);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Waste:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 208);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 11;
            label7.Text = "Speed:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(53, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Dead";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            apply.Location = new Point(12, 415);
            apply.Name = "apply";
            apply.Size = new Size(261, 23);
            apply.TabIndex = 17;
            apply.Text = "Apply";
            apply.UseVisualStyleBackColor = true;
            // 
            // ModifyProp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 450);
            Controls.Add(apply);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(energy);
            Controls.Add(label3);
            Controls.Add(sensy);
            Controls.Add(sensx);
            Controls.Add(label2);
            Controls.Add(posy);
            Controls.Add(posx);
            Controls.Add(label1);
            Name = "ModifyProp";
            Text = "ModifyProp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox posx;
        private TextBox posy;
        private TextBox sensy;
        private TextBox sensx;
        private Label label2;
        private Label label3;
        private TextBox energy;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private CheckBox checkBox1;
        private Button apply;
    }
}