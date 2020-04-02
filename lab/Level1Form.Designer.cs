namespace lab
{
    partial class Level1Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelfinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(-10, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 453);
            this.label1.TabIndex = 0;
            this.label1.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(756, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 453);
            this.label2.TabIndex = 1;
            this.label2.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(-10, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(816, 32);
            this.label3.TabIndex = 2;
            this.label3.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(-10, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(816, 32);
            this.label4.TabIndex = 3;
            this.label4.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(303, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 299);
            this.label5.TabIndex = 4;
            this.label5.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            // 
            // labelfinish
            // 
            this.labelfinish.BackColor = System.Drawing.Color.Aqua;
            this.labelfinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfinish.Location = new System.Drawing.Point(637, 350);
            this.labelfinish.Name = "labelfinish";
            this.labelfinish.Size = new System.Drawing.Size(113, 57);
            this.labelfinish.TabIndex = 5;
            this.labelfinish.Text = "Финиш";
            this.labelfinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelfinish.MouseEnter += new System.EventHandler(this.Labelfinish_MouseEnter);
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.Yellow;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(46, 45);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(113, 57);
            this.labelStart.TabIndex = 6;
            this.labelStart.Text = "Старт";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelfinish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Level1Form";
            this.Text = "Level1Form";
            this.Shown += new System.EventHandler(this.Level1Form_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelfinish;
        private System.Windows.Forms.Label labelStart;
    }
}