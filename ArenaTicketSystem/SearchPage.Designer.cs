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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPage));
            this.eventLabel = new System.Windows.Forms.Label();
            this.rowLabel = new System.Windows.Forms.Label();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.rowComboBox = new System.Windows.Forms.ComboBox();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.searchPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchPicturebox)).BeginInit();
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
            this.rowLabel.Location = new System.Drawing.Point(47, 231);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(49, 20);
            this.rowLabel.TabIndex = 1;
            this.rowLabel.Text = "Row :";
            this.rowLabel.Click += new System.EventHandler(this.rowLabel_Click);
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
            // rowComboBox
            // 
            this.rowComboBox.FormattingEnabled = true;
            this.rowComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rowComboBox.Location = new System.Drawing.Point(51, 271);
            this.rowComboBox.Name = "rowComboBox";
            this.rowComboBox.Size = new System.Drawing.Size(121, 21);
            this.rowComboBox.TabIndex = 4;
            this.rowComboBox.SelectedIndexChanged += new System.EventHandler(this.imageSelector);
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.sectionComboBox.Location = new System.Drawing.Point(51, 171);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 5;
            this.sectionComboBox.SelectedIndexChanged += new System.EventHandler(this.imageSelector);
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.Location = new System.Drawing.Point(47, 116);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(71, 20);
            this.sectionLabel.TabIndex = 6;
            this.sectionLabel.Text = "Section :";
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(51, 324);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(105, 58);
            this.bookButton.TabIndex = 8;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click_1);
            // 
            // searchPicturebox
            // 
            this.searchPicturebox.Location = new System.Drawing.Point(274, 63);
            this.searchPicturebox.Name = "searchPicturebox";
            this.searchPicturebox.Size = new System.Drawing.Size(377, 280);
            this.searchPicturebox.TabIndex = 9;
            this.searchPicturebox.TabStop = false;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.searchPicturebox);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.rowComboBox);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.rowLabel);
            this.Controls.Add(this.eventLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPage";
            this.Text = "SearchPage";
            this.Load += new System.EventHandler(this.SearchPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.ComboBox rowComboBox;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.PictureBox searchPicturebox;
    }
}