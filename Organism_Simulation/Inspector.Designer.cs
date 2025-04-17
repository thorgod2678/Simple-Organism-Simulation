namespace Organism_Simulation
{
    partial class Inspector
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            orgno = new Label();
            nofood = new Label();
            modprop = new Button();
            inspuf = new TextBox();
            label3 = new Label();
            select = new Button();
            deselct = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(12, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(811, 378);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Thin", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 1;
            label1.Text = "Organism Statistics:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(829, 64);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Update Interval:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(925, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(829, 400);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(910, 400);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Pause";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(991, 400);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Step";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // orgno
            // 
            orgno.AutoSize = true;
            orgno.Location = new Point(829, 123);
            orgno.Name = "orgno";
            orgno.Size = new Size(129, 15);
            orgno.TabIndex = 7;
            orgno.Text = "Total No. of organisms:";
            // 
            // nofood
            // 
            nofood.AutoSize = true;
            nofood.Location = new Point(829, 152);
            nofood.Name = "nofood";
            nofood.Size = new Size(146, 15);
            nofood.TabIndex = 8;
            nofood.Text = "Total No. of food particles:";
            // 
            // modprop
            // 
            modprop.Location = new Point(873, 371);
            modprop.Name = "modprop";
            modprop.Size = new Size(153, 23);
            modprop.TabIndex = 9;
            modprop.Text = "Modify Propertites";
            modprop.UseVisualStyleBackColor = true;
            modprop.Click += modprop_Click;
            // 
            // inspuf
            // 
            inspuf.Location = new Point(968, 85);
            inspuf.Name = "inspuf";
            inspuf.Size = new Size(100, 23);
            inspuf.TabIndex = 11;
            inspuf.TextChanged += inspuf_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(829, 93);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 10;
            label3.Text = "Inspector Update Factor:";
            label3.Click += label3_Click;
            // 
            // select
            // 
            select.Location = new Point(873, 342);
            select.Name = "select";
            select.Size = new Size(71, 23);
            select.TabIndex = 12;
            select.Text = "Select";
            select.UseVisualStyleBackColor = true;
            select.Click += select_Click;
            // 
            // deselct
            // 
            deselct.Location = new Point(950, 342);
            deselct.Name = "deselct";
            deselct.Size = new Size(75, 23);
            deselct.TabIndex = 13;
            deselct.Text = "Deselect";
            deselct.UseVisualStyleBackColor = true;
            deselct.Click += deselct_Click;
            // 
            // Inspector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1178, 450);
            Controls.Add(deselct);
            Controls.Add(select);
            Controls.Add(inspuf);
            Controls.Add(label3);
            Controls.Add(modprop);
            Controls.Add(nofood);
            Controls.Add(orgno);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            DoubleBuffered = true;
            HelpButton = true;
            MaximumSize = new Size(1194, 489);
            MinimumSize = new Size(1194, 489);
            Name = "Inspector";
            Text = "Inspector";
            Load += Inspector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label orgno;
        private Label nofood;
        private Button modprop;
        private TextBox inspuf;
        private Label label3;
        private Button select;
        private Button deselct;
    }
}