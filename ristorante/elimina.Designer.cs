
namespace ristorante
{
    partial class elimina
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
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.godo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 27);
            this.button2.TabIndex = 30;
            this.button2.Text = "Ellimina temporaneamente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Piatto che vuoi eliminare:";
            // 
            // godo
            // 
            this.godo.Location = new System.Drawing.Point(102, 165);
            this.godo.Name = "godo";
            this.godo.Size = new System.Drawing.Size(117, 20);
            this.godo.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 22);
            this.button1.TabIndex = 31;
            this.button1.Text = "Elimina definitiva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elimina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.godo);
            this.Name = "elimina";
            this.Text = "elimina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox godo;
        private System.Windows.Forms.Button button1;
    }
}