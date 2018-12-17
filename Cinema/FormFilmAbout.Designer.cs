namespace Cinema
{
    partial class FormFilmAbout
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
            this.tBPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCinema = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBAmountP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.tBFilm = new System.Windows.Forms.TextBox();
            this.tBCard = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBPlace
            // 
            this.tBPlace.Location = new System.Drawing.Point(12, 12);
            this.tBPlace.Name = "tBPlace";
            this.tBPlace.Size = new System.Drawing.Size(335, 22);
            this.tBPlace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(682, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the hall: ";
            // 
            // cBCinema
            // 
            this.cBCinema.FormattingEnabled = true;
            this.cBCinema.Items.AddRange(new object[] {
            "Red Hall",
            "Black Hall",
            "Terracotta Hall",
            "Gray Hall"});
            this.cBCinema.Location = new System.Drawing.Point(964, 22);
            this.cBCinema.Name = "cBCinema";
            this.cBCinema.Size = new System.Drawing.Size(270, 24);
            this.cBCinema.TabIndex = 2;
            this.cBCinema.SelectedIndexChanged += new System.EventHandler(this.cBCinema_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(832, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "More Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(680, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(612, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Your key code:";
            // 
            // TbCode
            // 
            this.TbCode.Location = new System.Drawing.Point(964, 191);
            this.TbCode.Name = "TbCode";
            this.TbCode.Size = new System.Drawing.Size(270, 22);
            this.TbCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(596, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount of people:";
            // 
            // tBAmountP
            // 
            this.tBAmountP.Location = new System.Drawing.Point(964, 244);
            this.tBAmountP.Name = "tBAmountP";
            this.tBAmountP.Size = new System.Drawing.Size(264, 22);
            this.tBAmountP.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(629, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Your Pay Card:";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Maroon;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuy.Location = new System.Drawing.Point(886, 446);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(115, 41);
            this.btnBuy.TabIndex = 13;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click_1);
            // 
            // tBFilm
            // 
            this.tBFilm.Location = new System.Drawing.Point(964, 128);
            this.tBFilm.Name = "tBFilm";
            this.tBFilm.Size = new System.Drawing.Size(270, 22);
            this.tBFilm.TabIndex = 15;
            // 
            // tBCard
            // 
            this.tBCard.Location = new System.Drawing.Point(970, 404);
            this.tBCard.Name = "tBCard";
            this.tBCard.Size = new System.Drawing.Size(264, 22);
            this.tBCard.TabIndex = 11;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayment.Location = new System.Drawing.Point(571, 330);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(304, 32);
            this.lblPayment.TabIndex = 16;
            this.lblPayment.Text = "This is your payment:";
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(970, 340);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(264, 22);
            this.tBPrice.TabIndex = 17;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Maroon;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheck.Location = new System.Drawing.Point(807, 272);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(249, 45);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.Text = "Cont Price";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // FormFilmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 595);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.tBFilm);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBCard);
            this.Controls.Add(this.tBAmountP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBCinema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPlace);
            this.Name = "FormFilmAbout";
            this.Text = "FilmAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCinema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBAmountP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox tBFilm;
        private System.Windows.Forms.TextBox tBCard;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.Button btnCheck;
    }
}