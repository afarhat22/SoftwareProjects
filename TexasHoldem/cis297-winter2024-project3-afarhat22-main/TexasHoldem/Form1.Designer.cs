namespace TexasHoldem
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            foldButton = new Button();
            betButton = new Button();
            checkButton = new Button();
            playerHoldemCardTwo = new Label();
            playerHoldemCardOne = new Label();
            holdemHandCardLabel = new Label();
            label2 = new Label();
            playerTurnIndicator = new Label();
            label1 = new Label();
            label3 = new Label();
            playerOneCashLabel = new Label();
            playerTwoCashLabel = new Label();
            potLabel = new Label();
            amountInPotLabel = new Label();
            tableCard1 = new Label();
            tableCard2 = new Label();
            tableCard3 = new Label();
            tableCard4 = new Label();
            tableCard5 = new Label();
            stageIndicator = new Label();
            playerOnePokerCardOneLabel = new Label();
            playerOnesPokerHandLabel = new Label();
            playerOnesPokerHandPanel = new Panel();
            PlayerOneRank = new Label();
            playAgainButton = new Button();
            playerTwosPokerHandPanel = new Panel();
            endGameButton = new Button();
            playerTwoRank = new Label();
            playerTwosPokerHandLabel = new Label();
            playerTwosPokerCardOneLabel = new Label();
            groupBox1.SuspendLayout();
            playerOnesPokerHandPanel.SuspendLayout();
            playerTwosPokerHandPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(foldButton);
            groupBox1.Controls.Add(betButton);
            groupBox1.Controls.Add(checkButton);
            groupBox1.Controls.Add(playerHoldemCardTwo);
            groupBox1.Controls.Add(playerHoldemCardOne);
            groupBox1.Controls.Add(holdemHandCardLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(playerTurnIndicator);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(11, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 444);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Welcome To Texas Holdem!";
            // 
            // foldButton
            // 
            foldButton.BackColor = Color.Bisque;
            foldButton.ForeColor = Color.Black;
            foldButton.Location = new Point(133, 390);
            foldButton.Name = "foldButton";
            foldButton.Size = new Size(130, 35);
            foldButton.TabIndex = 7;
            foldButton.Text = "Fold";
            foldButton.UseVisualStyleBackColor = false;
            foldButton.Click += foldButton_Click;
            // 
            // betButton
            // 
            betButton.BackColor = Color.Bisque;
            betButton.ForeColor = Color.Black;
            betButton.Location = new Point(6, 354);
            betButton.Name = "betButton";
            betButton.Size = new Size(256, 35);
            betButton.TabIndex = 6;
            betButton.Text = "Bet $1";
            betButton.UseVisualStyleBackColor = false;
            betButton.Click += betButton_Click;
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.Bisque;
            checkButton.ForeColor = Color.Black;
            checkButton.Location = new Point(6, 390);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(126, 35);
            checkButton.TabIndex = 5;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // playerHoldemCardTwo
            // 
            playerHoldemCardTwo.AutoSize = true;
            playerHoldemCardTwo.Location = new Point(11, 148);
            playerHoldemCardTwo.Name = "playerHoldemCardTwo";
            playerHoldemCardTwo.Size = new Size(60, 20);
            playerHoldemCardTwo.TabIndex = 4;
            playerHoldemCardTwo.Text = "(card 2)";
            // 
            // playerHoldemCardOne
            // 
            playerHoldemCardOne.AutoSize = true;
            playerHoldemCardOne.Location = new Point(11, 117);
            playerHoldemCardOne.Name = "playerHoldemCardOne";
            playerHoldemCardOne.Size = new Size(60, 20);
            playerHoldemCardOne.TabIndex = 3;
            playerHoldemCardOne.Text = "(card 1)";
            // 
            // holdemHandCardLabel
            // 
            holdemHandCardLabel.AutoSize = true;
            holdemHandCardLabel.Location = new Point(6, 105);
            holdemHandCardLabel.Name = "holdemHandCardLabel";
            holdemHandCardLabel.Size = new Size(0, 20);
            holdemHandCardLabel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 1;
            label2.Text = "Cards In Hand:";
            // 
            // playerTurnIndicator
            // 
            playerTurnIndicator.AutoSize = true;
            playerTurnIndicator.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerTurnIndicator.Location = new Point(6, 37);
            playerTurnIndicator.Name = "playerTurnIndicator";
            playerTurnIndicator.Size = new Size(173, 30);
            playerTurnIndicator.TabIndex = 0;
            playerTurnIndicator.Text = "Player 1's turn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 27);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 13;
            label1.Text = "Player 1's Cash:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 65);
            label3.Name = "label3";
            label3.Size = new Size(192, 30);
            label3.TabIndex = 14;
            label3.Text = "Player 2's Cash:";
            // 
            // playerOneCashLabel
            // 
            playerOneCashLabel.AutoSize = true;
            playerOneCashLabel.BackColor = Color.Transparent;
            playerOneCashLabel.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerOneCashLabel.ForeColor = Color.FromArgb(0, 192, 0);
            playerOneCashLabel.Location = new Point(507, 27);
            playerOneCashLabel.Name = "playerOneCashLabel";
            playerOneCashLabel.Size = new Size(0, 30);
            playerOneCashLabel.TabIndex = 15;
            // 
            // playerTwoCashLabel
            // 
            playerTwoCashLabel.AutoSize = true;
            playerTwoCashLabel.BackColor = Color.Transparent;
            playerTwoCashLabel.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playerTwoCashLabel.ForeColor = Color.FromArgb(0, 192, 0);
            playerTwoCashLabel.Location = new Point(507, 65);
            playerTwoCashLabel.Name = "playerTwoCashLabel";
            playerTwoCashLabel.Size = new Size(0, 30);
            playerTwoCashLabel.TabIndex = 16;
            // 
            // potLabel
            // 
            potLabel.AutoSize = true;
            potLabel.BackColor = Color.White;
            potLabel.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            potLabel.Location = new Point(583, 44);
            potLabel.Name = "potLabel";
            potLabel.Size = new Size(59, 30);
            potLabel.TabIndex = 17;
            potLabel.Text = "Pot:";
            // 
            // amountInPotLabel
            // 
            amountInPotLabel.AutoSize = true;
            amountInPotLabel.BackColor = Color.Transparent;
            amountInPotLabel.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountInPotLabel.ForeColor = Color.FromArgb(0, 192, 0);
            amountInPotLabel.Location = new Point(648, 44);
            amountInPotLabel.Name = "amountInPotLabel";
            amountInPotLabel.Size = new Size(0, 30);
            amountInPotLabel.TabIndex = 18;
            // 
            // tableCard1
            // 
            tableCard1.AutoSize = true;
            tableCard1.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCard1.ForeColor = Color.White;
            tableCard1.Location = new Point(475, 311);
            tableCard1.Name = "tableCard1";
            tableCard1.Size = new Size(26, 45);
            tableCard1.TabIndex = 19;
            tableCard1.Text = ".";
            // 
            // tableCard2
            // 
            tableCard2.AutoSize = true;
            tableCard2.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCard2.ForeColor = Color.White;
            tableCard2.Location = new Point(475, 342);
            tableCard2.Name = "tableCard2";
            tableCard2.Size = new Size(26, 45);
            tableCard2.TabIndex = 20;
            tableCard2.Text = ".";
            // 
            // tableCard3
            // 
            tableCard3.AutoSize = true;
            tableCard3.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCard3.ForeColor = Color.White;
            tableCard3.Location = new Point(475, 372);
            tableCard3.Name = "tableCard3";
            tableCard3.Size = new Size(26, 45);
            tableCard3.TabIndex = 21;
            tableCard3.Text = ".";
            // 
            // tableCard4
            // 
            tableCard4.AutoSize = true;
            tableCard4.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCard4.ForeColor = Color.White;
            tableCard4.Location = new Point(475, 406);
            tableCard4.Name = "tableCard4";
            tableCard4.Size = new Size(26, 45);
            tableCard4.TabIndex = 22;
            tableCard4.Text = ".";
            // 
            // tableCard5
            // 
            tableCard5.AutoSize = true;
            tableCard5.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableCard5.ForeColor = Color.White;
            tableCard5.Location = new Point(475, 436);
            tableCard5.Name = "tableCard5";
            tableCard5.Size = new Size(26, 45);
            tableCard5.TabIndex = 23;
            tableCard5.Text = ".";
            // 
            // stageIndicator
            // 
            stageIndicator.AutoSize = true;
            stageIndicator.BackColor = Color.Transparent;
            stageIndicator.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stageIndicator.ForeColor = Color.FromArgb(255, 255, 192);
            stageIndicator.Location = new Point(427, 482);
            stageIndicator.Name = "stageIndicator";
            stageIndicator.Size = new Size(119, 35);
            stageIndicator.TabIndex = 24;
            stageIndicator.Text = "Pre-Flop";
            // 
            // playerOnePokerCardOneLabel
            // 
            playerOnePokerCardOneLabel.AutoSize = true;
            playerOnePokerCardOneLabel.Font = new Font("Javanese Text", 10.2F);
            playerOnePokerCardOneLabel.ForeColor = Color.White;
            playerOnePokerCardOneLabel.Location = new Point(102, 61);
            playerOnePokerCardOneLabel.Name = "playerOnePokerCardOneLabel";
            playerOnePokerCardOneLabel.Size = new Size(22, 38);
            playerOnePokerCardOneLabel.TabIndex = 25;
            playerOnePokerCardOneLabel.Text = ".";
            // 
            // playerOnesPokerHandLabel
            // 
            playerOnesPokerHandLabel.AutoSize = true;
            playerOnesPokerHandLabel.BorderStyle = BorderStyle.FixedSingle;
            playerOnesPokerHandLabel.Font = new Font("Javanese Text", 10.2F);
            playerOnesPokerHandLabel.ForeColor = Color.White;
            playerOnesPokerHandLabel.Location = new Point(102, 21);
            playerOnesPokerHandLabel.Name = "playerOnesPokerHandLabel";
            playerOnesPokerHandLabel.Size = new Size(195, 40);
            playerOnesPokerHandLabel.TabIndex = 30;
            playerOnesPokerHandLabel.Text = "Player One's PokerHand";
            // 
            // playerOnesPokerHandPanel
            // 
            playerOnesPokerHandPanel.Controls.Add(PlayerOneRank);
            playerOnesPokerHandPanel.Controls.Add(playerOnesPokerHandLabel);
            playerOnesPokerHandPanel.Controls.Add(playerOnePokerCardOneLabel);
            playerOnesPokerHandPanel.Location = new Point(11, 103);
            playerOnesPokerHandPanel.Name = "playerOnesPokerHandPanel";
            playerOnesPokerHandPanel.Size = new Size(433, 414);
            playerOnesPokerHandPanel.TabIndex = 31;
            playerOnesPokerHandPanel.Visible = false;
            // 
            // PlayerOneRank
            // 
            PlayerOneRank.AutoSize = true;
            PlayerOneRank.Font = new Font("Lucida Bright", 16.2F);
            PlayerOneRank.ForeColor = Color.Cyan;
            PlayerOneRank.Location = new Point(102, 269);
            PlayerOneRank.Name = "PlayerOneRank";
            PlayerOneRank.Size = new Size(21, 32);
            PlayerOneRank.TabIndex = 31;
            PlayerOneRank.Text = ".";
            // 
            // playAgainButton
            // 
            playAgainButton.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playAgainButton.Location = new Point(243, 333);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(213, 75);
            playAgainButton.TabIndex = 32;
            playAgainButton.Text = "Next Round?";
            playAgainButton.UseVisualStyleBackColor = true;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // playerTwosPokerHandPanel
            // 
            playerTwosPokerHandPanel.Controls.Add(endGameButton);
            playerTwosPokerHandPanel.Controls.Add(playAgainButton);
            playerTwosPokerHandPanel.Controls.Add(playerTwoRank);
            playerTwosPokerHandPanel.Controls.Add(playerTwosPokerHandLabel);
            playerTwosPokerHandPanel.Controls.Add(playerTwosPokerCardOneLabel);
            playerTwosPokerHandPanel.Location = new Point(450, 103);
            playerTwosPokerHandPanel.Name = "playerTwosPokerHandPanel";
            playerTwosPokerHandPanel.Size = new Size(459, 414);
            playerTwosPokerHandPanel.TabIndex = 32;
            playerTwosPokerHandPanel.Visible = false;
            // 
            // endGameButton
            // 
            endGameButton.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endGameButton.Location = new Point(24, 333);
            endGameButton.Name = "endGameButton";
            endGameButton.RightToLeft = RightToLeft.Yes;
            endGameButton.Size = new Size(213, 75);
            endGameButton.TabIndex = 33;
            endGameButton.Text = "End Game";
            endGameButton.UseVisualStyleBackColor = true;
            endGameButton.Click += endGameButton_Click;
            // 
            // playerTwoRank
            // 
            playerTwoRank.AutoSize = true;
            playerTwoRank.Font = new Font("Lucida Bright", 16.2F);
            playerTwoRank.ForeColor = Color.Cyan;
            playerTwoRank.Location = new Point(29, 269);
            playerTwoRank.Name = "playerTwoRank";
            playerTwoRank.Size = new Size(21, 32);
            playerTwoRank.TabIndex = 32;
            playerTwoRank.Text = ".";
            // 
            // playerTwosPokerHandLabel
            // 
            playerTwosPokerHandLabel.AutoSize = true;
            playerTwosPokerHandLabel.BorderStyle = BorderStyle.FixedSingle;
            playerTwosPokerHandLabel.Font = new Font("Javanese Text", 10.2F);
            playerTwosPokerHandLabel.ForeColor = Color.White;
            playerTwosPokerHandLabel.Location = new Point(26, 15);
            playerTwosPokerHandLabel.Name = "playerTwosPokerHandLabel";
            playerTwosPokerHandLabel.Size = new Size(197, 40);
            playerTwosPokerHandLabel.TabIndex = 30;
            playerTwosPokerHandLabel.Text = "Player Two's PokerHand";
            // 
            // playerTwosPokerCardOneLabel
            // 
            playerTwosPokerCardOneLabel.AutoSize = true;
            playerTwosPokerCardOneLabel.Font = new Font("Javanese Text", 10.2F);
            playerTwosPokerCardOneLabel.ForeColor = Color.White;
            playerTwosPokerCardOneLabel.Location = new Point(29, 67);
            playerTwosPokerCardOneLabel.Name = "playerTwosPokerCardOneLabel";
            playerTwosPokerCardOneLabel.Size = new Size(22, 38);
            playerTwosPokerCardOneLabel.TabIndex = 25;
            playerTwosPokerCardOneLabel.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(945, 667);
            Controls.Add(playerTwosPokerHandPanel);
            Controls.Add(playerOnesPokerHandPanel);
            Controls.Add(stageIndicator);
            Controls.Add(tableCard5);
            Controls.Add(tableCard4);
            Controls.Add(tableCard3);
            Controls.Add(tableCard2);
            Controls.Add(tableCard1);
            Controls.Add(amountInPotLabel);
            Controls.Add(potLabel);
            Controls.Add(playerTwoCashLabel);
            Controls.Add(playerOneCashLabel);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            playerOnesPokerHandPanel.ResumeLayout(false);
            playerOnesPokerHandPanel.PerformLayout();
            playerTwosPokerHandPanel.ResumeLayout(false);
            playerTwosPokerHandPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deckLabel;
        private Label playerSelectorInfoLabel;
        private GroupBox groupBox1;
        private Label label2;
        private Label playerTurnIndicator;
        private Label holdemHandCardLabel;
        private Label label1;
        private Label label3;
        private Label playerOneCashLabel;
        private Label playerTwoCashLabel;
        private Label potLabel;
        private Label amountInPotLabel;
        private Label playerHoldemCardOne;
        private Label playerHoldemCardTwo;
        private Button checkButton;
        private Label tableCard1;
        private Label tableCard2;
        private Label tableCard3;
        private Label tableCard4;
        private Label tableCard5;
        private Label stageIndicator;
        private Button betButton;
        private Button foldButton;
        private Label playerOnePokerCardOneLabel;
        private Label playerOnesPokerHandLabel;
        private Panel playerOnesPokerHandPanel;
        private Panel playerTwosPokerHandPanel;
        private Label playerTwosPokerHandLabel;
        private Label playerTwosPokerCardOneLabel;
        private Button playAgainButton;
        private Label PlayerOneRank;
        private Label playerTwoRank;
        private Button endGameButton;
    }
}
