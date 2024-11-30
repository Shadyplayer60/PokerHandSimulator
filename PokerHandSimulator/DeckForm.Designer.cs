namespace PokerHandSimulator
{
    partial class DeckForm
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
            lstCards = new ListBox();
            lblCards = new Label();
            btnUp = new Button();
            btnDown = new Button();
            picCard6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCard6).BeginInit();
            SuspendLayout();
            // 
            // lstCards
            // 
            lstCards.FormattingEnabled = true;
            lstCards.ItemHeight = 25;
            lstCards.Location = new Point(133, 76);
            lstCards.Name = "lstCards";
            lstCards.Size = new Size(212, 329);
            lstCards.TabIndex = 0;
            lstCards.SelectedIndexChanged += lstCards_SelectedIndexChanged;
            // 
            // lblCards
            // 
            lblCards.AutoSize = true;
            lblCards.Location = new Point(133, 48);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(57, 25);
            lblCards.TabIndex = 0;
            lblCards.Text = "&Cards";
            // 
            // btnUp
            // 
            btnUp.Location = new Point(15, 98);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(112, 67);
            btnUp.TabIndex = 2;
            btnUp.Text = "&Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(15, 171);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(112, 67);
            btnDown.TabIndex = 3;
            btnDown.Text = "&Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // picCard6
            // 
            picCard6.Location = new Point(351, 105);
            picCard6.Name = "picCard6";
            picCard6.Size = new Size(200, 300);
            picCard6.TabIndex = 4;
            picCard6.TabStop = false;
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(593, 425);
            Controls.Add(picCard6);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(lblCards);
            Controls.Add(lstCards);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "Deck";
            Load += DeckForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCard6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCards;
        private Label lblCards;
        private Button btnUp;
        private Button btnDown;
        private PictureBox picCard6;
    }
}