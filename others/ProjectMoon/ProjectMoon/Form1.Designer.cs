namespace ProjectMoon
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fuel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Attitude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed:";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.ForeColor = System.Drawing.Color.Chartreuse;
            this.Speed.Location = new System.Drawing.Point(84, 9);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(13, 13);
            this.Speed.TabIndex = 1;
            this.Speed.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mass:";
            // 
            // Mass
            // 
            this.Mass.AutoSize = true;
            this.Mass.ForeColor = System.Drawing.Color.Chartreuse;
            this.Mass.Location = new System.Drawing.Point(84, 35);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(13, 13);
            this.Mass.TabIndex = 3;
            this.Mass.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fuel:";
            // 
            // Fuel
            // 
            this.Fuel.AutoSize = true;
            this.Fuel.ForeColor = System.Drawing.Color.Chartreuse;
            this.Fuel.Location = new System.Drawing.Point(84, 65);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(13, 13);
            this.Fuel.TabIndex = 5;
            this.Fuel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(659, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attitude:";
            // 
            // Attitude
            // 
            this.Attitude.AutoSize = true;
            this.Attitude.ForeColor = System.Drawing.Color.Chartreuse;
            this.Attitude.Location = new System.Drawing.Point(745, 9);
            this.Attitude.Name = "Attitude";
            this.Attitude.Size = new System.Drawing.Size(13, 13);
            this.Attitude.TabIndex = 7;
            this.Attitude.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Attitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Fuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Attitude;
    }
}

