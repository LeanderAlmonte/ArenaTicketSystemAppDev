namespace ArenaTicketSystem
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.confirmButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.addLabel = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.cardTbox = new System.Windows.Forms.TextBox();
            this.addTbox = new System.Windows.Forms.TextBox();
            this.CVVTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(476, 377);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(111, 35);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(310, 377);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 35);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticket Info :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 292);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(296, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name :";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.Location = new System.Drawing.Point(296, 114);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(111, 20);
            this.cardLabel.TabIndex = 5;
            this.cardLabel.Text = "Card Number :";
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLabel.Location = new System.Drawing.Point(296, 173);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(121, 20);
            this.addLabel.TabIndex = 6;
            this.addLabel.Text = "Billing Address :";
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.Location = new System.Drawing.Point(296, 228);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(50, 20);
            this.CVVLabel.TabIndex = 7;
            this.CVVLabel.Text = "CVV :";
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(411, 75);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(176, 20);
            this.nameTbox.TabIndex = 8;
            // 
            // cardTbox
            // 
            this.cardTbox.Location = new System.Drawing.Point(411, 134);
            this.cardTbox.Name = "cardTbox";
            this.cardTbox.Size = new System.Drawing.Size(176, 20);
            this.cardTbox.TabIndex = 9;
            // 
            // addTbox
            // 
            this.addTbox.Location = new System.Drawing.Point(411, 196);
            this.addTbox.Name = "addTbox";
            this.addTbox.Size = new System.Drawing.Size(176, 20);
            this.addTbox.TabIndex = 10;
            // 
            // CVVTbox
            // 
            this.CVVTbox.Location = new System.Drawing.Point(411, 264);
            this.CVVTbox.Name = "CVVTbox";
            this.CVVTbox.Size = new System.Drawing.Size(176, 20);
            this.CVVTbox.TabIndex = 11;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.CVVTbox);
            this.Controls.Add(this.addTbox);
            this.Controls.Add(this.cardTbox);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.confirmButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.TextBox cardTbox;
        private System.Windows.Forms.TextBox addTbox;
        private System.Windows.Forms.TextBox CVVTbox;
    }
}