namespace Card_Identifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.twoOfHearts = new System.Windows.Forms.PictureBox();
            this.twoOfSpades = new System.Windows.Forms.PictureBox();
            this.fourOfSpades = new System.Windows.Forms.PictureBox();
            this.fiveOfHearts = new System.Windows.Forms.PictureBox();
            this.eightOfClubs = new System.Windows.Forms.PictureBox();
            this.nameOfCardChoosen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.twoOfHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoOfSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourOfSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveOfHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightOfClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a Card to See Its Name";
            // 
            // twoOfHearts
            // 
            this.twoOfHearts.Image = global::Card_Identifier.Properties.Resources._2_Hearts;
            this.twoOfHearts.Location = new System.Drawing.Point(39, 133);
            this.twoOfHearts.Name = "twoOfHearts";
            this.twoOfHearts.Size = new System.Drawing.Size(125, 175);
            this.twoOfHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoOfHearts.TabIndex = 1;
            this.twoOfHearts.TabStop = false;
            this.twoOfHearts.Click += new System.EventHandler(this.twoOfHearts_Click);
            // 
            // twoOfSpades
            // 
            this.twoOfSpades.Image = global::Card_Identifier.Properties.Resources._2_Spades;
            this.twoOfSpades.Location = new System.Drawing.Point(206, 133);
            this.twoOfSpades.Name = "twoOfSpades";
            this.twoOfSpades.Size = new System.Drawing.Size(125, 175);
            this.twoOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoOfSpades.TabIndex = 2;
            this.twoOfSpades.TabStop = false;
            this.twoOfSpades.Click += new System.EventHandler(this.twoOfSpades_Click);
            // 
            // fourOfSpades
            // 
            this.fourOfSpades.Image = global::Card_Identifier.Properties.Resources._4_Spades;
            this.fourOfSpades.Location = new System.Drawing.Point(366, 133);
            this.fourOfSpades.Name = "fourOfSpades";
            this.fourOfSpades.Size = new System.Drawing.Size(125, 175);
            this.fourOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourOfSpades.TabIndex = 3;
            this.fourOfSpades.TabStop = false;
            this.fourOfSpades.Click += new System.EventHandler(this.fourOfSpades_Click);
            // 
            // fiveOfHearts
            // 
            this.fiveOfHearts.Image = global::Card_Identifier.Properties.Resources._5_Hearts;
            this.fiveOfHearts.Location = new System.Drawing.Point(522, 133);
            this.fiveOfHearts.Name = "fiveOfHearts";
            this.fiveOfHearts.Size = new System.Drawing.Size(125, 175);
            this.fiveOfHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiveOfHearts.TabIndex = 4;
            this.fiveOfHearts.TabStop = false;
            this.fiveOfHearts.Click += new System.EventHandler(this.fiveOfHearts_Click);
            // 
            // eightOfClubs
            // 
            this.eightOfClubs.Image = global::Card_Identifier.Properties.Resources._8_Clubs;
            this.eightOfClubs.Location = new System.Drawing.Point(677, 133);
            this.eightOfClubs.Name = "eightOfClubs";
            this.eightOfClubs.Size = new System.Drawing.Size(125, 175);
            this.eightOfClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eightOfClubs.TabIndex = 5;
            this.eightOfClubs.TabStop = false;
            this.eightOfClubs.Click += new System.EventHandler(this.eightOfClubs_Click);
            // 
            // nameOfCardChoosen
            // 
            this.nameOfCardChoosen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOfCardChoosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfCardChoosen.Location = new System.Drawing.Point(202, 334);
            this.nameOfCardChoosen.Name = "nameOfCardChoosen";
            this.nameOfCardChoosen.Size = new System.Drawing.Size(445, 56);
            this.nameOfCardChoosen.TabIndex = 6;
            this.nameOfCardChoosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.nameOfCardChoosen);
            this.Controls.Add(this.eightOfClubs);
            this.Controls.Add(this.fiveOfHearts);
            this.Controls.Add(this.fourOfSpades);
            this.Controls.Add(this.twoOfSpades);
            this.Controls.Add(this.twoOfHearts);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.twoOfHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoOfSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourOfSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveOfHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightOfClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox twoOfHearts;
        private System.Windows.Forms.PictureBox twoOfSpades;
        private System.Windows.Forms.PictureBox fourOfSpades;
        private System.Windows.Forms.PictureBox fiveOfHearts;
        private System.Windows.Forms.PictureBox eightOfClubs;
        private System.Windows.Forms.Label nameOfCardChoosen;
    }
}

