namespace ArenaTicketSystem
{
    partial class SearchPage
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
            this.eventLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.rowComboCox = new System.Windows.Forms.ComboBox();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLabel.Location = new System.Drawing.Point(47, 30);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(58, 20);
            this.eventLabel.TabIndex = 0;
            this.eventLabel.Text = "Event :";
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLabel.Location = new System.Drawing.Point(47, 116);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(49, 20);
            this.rowLabel.TabIndex = 1;
            this.rowLabel.Text = "Row :";
            this.rowLabel.Click += new System.EventHandler(this.rowLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(389, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 382);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // eventComboBox
            // 
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Items.AddRange(new object[] {
            "Hockey",
            "BasketBall",
            "Concert"});
            this.eventComboBox.Location = new System.Drawing.Point(51, 63);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(121, 21);
            this.eventComboBox.TabIndex = 3;
            // 
            // rowComboCox
            // 
            this.rowComboCox.FormattingEnabled = true;
            this.rowComboCox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rowComboCox.Location = new System.Drawing.Point(51, 156);
            this.rowComboCox.Name = "rowComboCox";
            this.rowComboCox.Size = new System.Drawing.Size(121, 21);
            this.rowComboCox.TabIndex = 4;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.sectionComboBox.Location = new System.Drawing.Point(51, 254);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 5;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.Location = new System.Drawing.Point(47, 199);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(71, 20);
            this.sectionLabel.TabIndex = 6;
            this.sectionLabel.Text = "Section :";
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.rowComboCox);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.eventLabel);
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.ComboBox rowComboCox;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.Label sectionLabel;
    }
}