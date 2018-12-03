namespace Cinema
{
    partial class FormTicketCheck
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPref = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(273, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(192, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO OUR CINEMA";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(170, 97);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(37, 17);
            this.lblFilm.TabIndex = 1;
            this.lblFilm.Text = "Film:";
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(173, 144);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(36, 17);
            this.lblHall.TabIndex = 2;
            this.lblHall.Text = "Hall:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(170, 183);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(53, 17);
            this.lblSector.TabIndex = 3;
            this.lblSector.Text = "Sector:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(170, 224);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(47, 17);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "Place:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(173, 260);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price:";
            // 
            // lblPref
            // 
            this.lblPref.AutoSize = true;
            this.lblPref.Location = new System.Drawing.Point(170, 309);
            this.lblPref.Name = "lblPref";
            this.lblPref.Size = new System.Drawing.Size(85, 17);
            this.lblPref.TabIndex = 6;
            this.lblPref.Text = "Preferential:";
            // 
            // FormTicketCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.lblPref);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormTicketCheck";
            this.Text = "Ticket Check";
            this.Load += new System.EventHandler(this.FormTicketCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPref;
    }
}