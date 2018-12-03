namespace Cinema
{
    partial class FormBuyTickets
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
            this.btnChooseFilm = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // btnChooseFilm
            // 
            this.btnChooseFilm.Location = new System.Drawing.Point(248, 237);
            this.btnChooseFilm.Name = "btnChooseFilm";
            this.btnChooseFilm.Size = new System.Drawing.Size(244, 66);
            this.btnChooseFilm.TabIndex = 2;
            this.btnChooseFilm.Text = "Choose a move";
            this.btnChooseFilm.UseVisualStyleBackColor = true;
            this.btnChooseFilm.Click += new System.EventHandler(this.btnChooseFilm_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(248, 336);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(244, 66);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About the cinema";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(248, 136);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(244, 66);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Sign In";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click_1);
            // 
            // FormBuyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnChooseFilm);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.label1);
            this.Name = "FormBuyTickets";
            this.Text = "BuyTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFilm;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnRegistration;
    }
}