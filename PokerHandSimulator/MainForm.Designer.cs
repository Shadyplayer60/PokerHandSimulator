namespace PokerHandSimulator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnDeal = new Button();
            btnShuffle = new Button();
            btnShowDeck = new Button();
            btnSaveHand = new Button();
            btnLoadHand = new Button();
            picCard1 = new PictureBox();
            picCard2 = new PictureBox();
            picCard3 = new PictureBox();
            picCard4 = new PictureBox();
            picCard5 = new PictureBox();
            chkKeep1 = new CheckBox();
            chkKeep2 = new CheckBox();
            chkKeep3 = new CheckBox();
            chkKeep4 = new CheckBox();
            chkKeep5 = new CheckBox();
            imageCardsList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(25, 16);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(138, 72);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "&Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(169, 16);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(138, 72);
            btnShuffle.TabIndex = 1;
            btnShuffle.Text = "&Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // btnShowDeck
            // 
            btnShowDeck.Location = new Point(486, 16);
            btnShowDeck.Name = "btnShowDeck";
            btnShowDeck.Size = new Size(138, 72);
            btnShowDeck.TabIndex = 2;
            btnShowDeck.Text = "&Show Deck";
            btnShowDeck.UseVisualStyleBackColor = true;
            btnShowDeck.Click += btnShowDeck_Click;
            // 
            // btnSaveHand
            // 
            btnSaveHand.Location = new Point(783, 16);
            btnSaveHand.Name = "btnSaveHand";
            btnSaveHand.Size = new Size(138, 72);
            btnSaveHand.TabIndex = 3;
            btnSaveHand.Text = "&Save Hand";
            btnSaveHand.UseVisualStyleBackColor = true;
            btnSaveHand.Click += btnSaveHand_Click;
            // 
            // btnLoadHand
            // 
            btnLoadHand.Location = new Point(927, 16);
            btnLoadHand.Name = "btnLoadHand";
            btnLoadHand.Size = new Size(138, 72);
            btnLoadHand.TabIndex = 4;
            btnLoadHand.Text = "&Load Hand";
            btnLoadHand.UseVisualStyleBackColor = true;
            btnLoadHand.Click += btnLoadHand_Click;
            // 
            // picCard1
            // 
            picCard1.Location = new Point(12, 191);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(200, 300);
            picCard1.TabIndex = 5;
            picCard1.TabStop = false;
            // 
            // picCard2
            // 
            picCard2.Location = new Point(218, 191);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(200, 300);
            picCard2.TabIndex = 6;
            picCard2.TabStop = false;
            // 
            // picCard3
            // 
            picCard3.Location = new Point(424, 191);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(200, 300);
            picCard3.TabIndex = 7;
            picCard3.TabStop = false;
            // 
            // picCard4
            // 
            picCard4.Location = new Point(630, 191);
            picCard4.Name = "picCard4";
            picCard4.Size = new Size(200, 300);
            picCard4.TabIndex = 8;
            picCard4.TabStop = false;
            // 
            // picCard5
            // 
            picCard5.Location = new Point(836, 191);
            picCard5.Name = "picCard5";
            picCard5.Size = new Size(200, 300);
            picCard5.TabIndex = 9;
            picCard5.TabStop = false;
            // 
            // chkKeep1
            // 
            chkKeep1.AutoSize = true;
            chkKeep1.Location = new Point(12, 156);
            chkKeep1.Name = "chkKeep1";
            chkKeep1.Size = new Size(134, 29);
            chkKeep1.TabIndex = 10;
            chkKeep1.Text = "&Keep Card 1";
            chkKeep1.UseVisualStyleBackColor = true;
            // 
            // chkKeep2
            // 
            chkKeep2.AutoSize = true;
            chkKeep2.Location = new Point(218, 156);
            chkKeep2.Name = "chkKeep2";
            chkKeep2.Size = new Size(134, 29);
            chkKeep2.TabIndex = 11;
            chkKeep2.Text = "&Keep Card 2";
            chkKeep2.UseVisualStyleBackColor = true;
            // 
            // chkKeep3
            // 
            chkKeep3.AutoSize = true;
            chkKeep3.Location = new Point(424, 156);
            chkKeep3.Name = "chkKeep3";
            chkKeep3.Size = new Size(134, 29);
            chkKeep3.TabIndex = 12;
            chkKeep3.Text = "&Keep Card 3";
            chkKeep3.UseVisualStyleBackColor = true;
            // 
            // chkKeep4
            // 
            chkKeep4.AutoSize = true;
            chkKeep4.Location = new Point(630, 156);
            chkKeep4.Name = "chkKeep4";
            chkKeep4.Size = new Size(134, 29);
            chkKeep4.TabIndex = 13;
            chkKeep4.Text = "&Keep Card 4";
            chkKeep4.UseVisualStyleBackColor = true;
            // 
            // chkKeep5
            // 
            chkKeep5.AutoSize = true;
            chkKeep5.Location = new Point(836, 156);
            chkKeep5.Name = "chkKeep5";
            chkKeep5.Size = new Size(134, 29);
            chkKeep5.TabIndex = 14;
            chkKeep5.Text = "&Keep Card 5";
            chkKeep5.UseVisualStyleBackColor = true;
            // 
            // imageCardsList
            // 
            imageCardsList.ColorDepth = ColorDepth.Depth32Bit;
            imageCardsList.ImageStream = (ImageListStreamer)resources.GetObject("imageCardsList.ImageStream");
            imageCardsList.TransparentColor = Color.Transparent;
            imageCardsList.Images.SetKeyName(0, "2 of Clubs");
            imageCardsList.Images.SetKeyName(1, "2 of Diamonds");
            imageCardsList.Images.SetKeyName(2, "2 of Hearts");
            imageCardsList.Images.SetKeyName(3, "2 of Spades");
            imageCardsList.Images.SetKeyName(4, "3 of Clubs");
            imageCardsList.Images.SetKeyName(5, "3 of Diamonds");
            imageCardsList.Images.SetKeyName(6, "3 of Hearts");
            imageCardsList.Images.SetKeyName(7, "3 of Spades");
            imageCardsList.Images.SetKeyName(8, "4 of Clubs");
            imageCardsList.Images.SetKeyName(9, "4 of Diamonds");
            imageCardsList.Images.SetKeyName(10, "4 of Hearts");
            imageCardsList.Images.SetKeyName(11, "4 of Spades");
            imageCardsList.Images.SetKeyName(12, "5 of Clubs");
            imageCardsList.Images.SetKeyName(13, "5 of Diamonds");
            imageCardsList.Images.SetKeyName(14, "5 of Hearts");
            imageCardsList.Images.SetKeyName(15, "5 of Spades");
            imageCardsList.Images.SetKeyName(16, "6 of Clubs");
            imageCardsList.Images.SetKeyName(17, "6 of Diamonds");
            imageCardsList.Images.SetKeyName(18, "6 of Hearts");
            imageCardsList.Images.SetKeyName(19, "6 of Spades");
            imageCardsList.Images.SetKeyName(20, "7 of Clubs");
            imageCardsList.Images.SetKeyName(21, "7 of Diamonds");
            imageCardsList.Images.SetKeyName(22, "7 of Hearts");
            imageCardsList.Images.SetKeyName(23, "7 of Spades");
            imageCardsList.Images.SetKeyName(24, "8 of Clubs");
            imageCardsList.Images.SetKeyName(25, "8 of Diamonds");
            imageCardsList.Images.SetKeyName(26, "8 of Hearts");
            imageCardsList.Images.SetKeyName(27, "8 of Spades");
            imageCardsList.Images.SetKeyName(28, "9 of Clubs");
            imageCardsList.Images.SetKeyName(29, "9 of Diamonds");
            imageCardsList.Images.SetKeyName(30, "9 of Hearts");
            imageCardsList.Images.SetKeyName(31, "9 of Spades");
            imageCardsList.Images.SetKeyName(32, "10 of Clubs");
            imageCardsList.Images.SetKeyName(33, "10 of Diamonds");
            imageCardsList.Images.SetKeyName(34, "10 of Hearts");
            imageCardsList.Images.SetKeyName(35, "10 of Spades");
            imageCardsList.Images.SetKeyName(36, "Ace of Clubs");
            imageCardsList.Images.SetKeyName(37, "Ace of Diamonds");
            imageCardsList.Images.SetKeyName(38, "Ace of Hearts");
            imageCardsList.Images.SetKeyName(39, "Ace of Spades");
            imageCardsList.Images.SetKeyName(40, "Jack of Clubs");
            imageCardsList.Images.SetKeyName(41, "Jack of Diamonds");
            imageCardsList.Images.SetKeyName(42, "Jack of Hearts.");
            imageCardsList.Images.SetKeyName(43, "Jack of Spades.");
            imageCardsList.Images.SetKeyName(44, "King of CLubs");
            imageCardsList.Images.SetKeyName(45, "King of Diamonds");
            imageCardsList.Images.SetKeyName(46, "King of Hearts");
            imageCardsList.Images.SetKeyName(47, "King of Spades");
            imageCardsList.Images.SetKeyName(48, "Queen of Clubs");
            imageCardsList.Images.SetKeyName(49, "Queen of Diamonds");
            imageCardsList.Images.SetKeyName(50, "Queen of Hearts");
            imageCardsList.Images.SetKeyName(51, "Queen of Spades");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1077, 503);
            Controls.Add(chkKeep5);
            Controls.Add(chkKeep4);
            Controls.Add(chkKeep3);
            Controls.Add(chkKeep2);
            Controls.Add(chkKeep1);
            Controls.Add(picCard5);
            Controls.Add(picCard4);
            Controls.Add(picCard3);
            Controls.Add(picCard2);
            Controls.Add(picCard1);
            Controls.Add(btnLoadHand);
            Controls.Add(btnSaveHand);
            Controls.Add(btnShowDeck);
            Controls.Add(btnShuffle);
            Controls.Add(btnDeal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Poker Hand Simulator";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeal;
        private Button btnShuffle;
        private Button btnShowDeck;
        private Button btnSaveHand;
        private Button btnLoadHand;
        private PictureBox picCard1;
        private PictureBox picCard2;
        private PictureBox picCard3;
        private PictureBox picCard4;
        private PictureBox picCard5;
        private CheckBox chkKeep1;
        private CheckBox chkKeep2;
        private CheckBox chkKeep3;
        private CheckBox chkKeep4;
        private CheckBox chkKeep5;
        private ImageList imageCardsList;
    }
}
