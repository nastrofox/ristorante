
namespace ristorante
{
    partial class proprietario
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benvenuto nella gestione menù:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aggiungi ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ricerca";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "Visualizza";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 67);
            this.button5.TabIndex = 5;
            this.button5.Text = "Elimina";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(46, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Piatti:";
            // 
            // Home
            // 
            this.Home.BackgroundImage = global::ristorante.Properties.Resources.casetta;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.Location = new System.Drawing.Point(402, 554);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(53, 52);
            this.Home.TabIndex = 10;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(293, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 67);
            this.button6.TabIndex = 11;
            this.button6.Text = "Recupera piatti eliminati";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // proprietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 618);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(483, 657);
            this.MinimumSize = new System.Drawing.Size(483, 657);
            this.Name = "proprietario";
            this.Text = "proprietario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button6;
    }
}