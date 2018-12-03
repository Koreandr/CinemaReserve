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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBChooseHall = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBAmountP = new System.Windows.Forms.TextBox();
            this.tBPayCard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.comBFilm = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(403, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the hall: ";
            // 
            // comBChooseHall
            // 
            this.comBChooseHall.FormattingEnabled = true;
            this.comBChooseHall.Items.AddRange(new object[] {
            "Red Hall",
            "Black Hall",
            "Terracotta Hall",
            "Gray Hall"});
            this.comBChooseHall.Location = new System.Drawing.Point(686, 38);
            this.comBChooseHall.Name = "comBChooseHall";
            this.comBChooseHall.Size = new System.Drawing.Size(270, 24);
            this.comBChooseHall.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(546, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "More Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(401, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(401, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Your key code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(654, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // tBCode
            // 
            this.tBCode.Location = new System.Drawing.Point(686, 212);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(270, 22);
            this.tBCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(401, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount of people:";
            // 
            // tBAmountP
            // 
            this.tBAmountP.Location = new System.Drawing.Point(692, 314);
            this.tBAmountP.Name = "tBAmountP";
            this.tBAmountP.Size = new System.Drawing.Size(264, 22);
            this.tBAmountP.TabIndex = 10;
            // 
            // tBPayCard
            // 
            this.tBPayCard.Location = new System.Drawing.Point(692, 384);
            this.tBPayCard.Name = "tBPayCard";
            this.tBPayCard.Size = new System.Drawing.Size(264, 22);
            this.tBPayCard.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(401, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Your Pay Card:";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Maroon;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuy.Location = new System.Drawing.Point(636, 429);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(115, 41);
            this.btnBuy.TabIndex = 13;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // comBFilm
            // 
            this.comBFilm.FormattingEnabled = true;
            this.comBFilm.Items.AddRange(new object[] {
            "Kill Spead",
            "Hitch",
            "Shark Tale",
            "Mission Impossible-Fallout",
            "The Shawshank Redemption",
            "Bridge to Terabithia"});
            this.comBFilm.Location = new System.Drawing.Point(686, 139);
            this.comBFilm.Name = "comBFilm";
            this.comBFilm.Size = new System.Drawing.Size(270, 24);
            this.comBFilm.TabIndex = 14;
            // 
            // FormFilmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 502);
            this.Controls.Add(this.comBFilm);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBPayCard);
            this.Controls.Add(this.tBAmountP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBChooseHall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormFilmAbout";
            this.Text = "FilmAbout";
            this.Load += new System.EventHandler(this.FormFilmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBChooseHall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBAmountP;
        private System.Windows.Forms.TextBox tBPayCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox comBFilm;
    }
}