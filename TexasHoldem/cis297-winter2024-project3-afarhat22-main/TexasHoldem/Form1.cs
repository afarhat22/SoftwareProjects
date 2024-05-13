using System.Security.Cryptography.X509Certificates;

namespace TexasHoldem
{
    public partial class Form1 : Form
    {
        bool playerOnesTurn = true;
        int currentRound = 0;
        public Form1()
        {
            InitializeComponent();
            Deck.ResetDeck();
            Deck.InitializePlayers();
            UpdateUIInformation();
        }



        public void UpdateUIInformation()
        {
            playerOneCashLabel.Text = "$" + Deck.players[0].money.ToString();
            playerTwoCashLabel.Text = "$" + Deck.players[1].money.ToString();

            if (playerOnesTurn)
            {
                playerTurnIndicator.Text = "Player 1's Turn";
                playerHoldemCardOne.Text = Deck.players[0].playerCards[0].ToString();
                playerHoldemCardTwo.Text = Deck.players[0].playerCards[1].ToString();
            }
            else
            {
                playerTurnIndicator.Text = "Player 2's Turn";
                playerHoldemCardOne.Text = Deck.players[1].playerCards[0].ToString();
                playerHoldemCardTwo.Text = Deck.players[1].playerCards[1].ToString();
            }

            amountInPotLabel.Text = "$" + Deck.pot.ToString();
            tableCard1.Text = Deck.tableCards[0]?.ToString();
            tableCard2.Text = Deck.tableCards[1]?.ToString();
            tableCard3.Text = Deck.tableCards[2]?.ToString();
            tableCard4.Text = Deck.tableCards[3]?.ToString();
            tableCard5.Text = Deck.tableCards[4]?.ToString();
        }

        private void NextRound()
        {
            currentRound++;
            Deck.UpdateTableCardsForNextRound();
            checkButton.Visible = true;
            if (currentRound == 1)
            {
                stageIndicator.Text = "The Flop";
            }
            else if (currentRound == 2)
            {
                stageIndicator.Text = "The Turn";
            }
            else if (currentRound == 3)
            {
                stageIndicator.Text = "The River";
            }
            else if (currentRound == 4)
            {
                currentRound = 0;
                EndRound();
            }
            playerOnesTurn = true;
            UpdateUIInformation();
        }

        private void EndRound()
        {
            var playerOnePokerHands = Deck.players[0].CalculatePokerHands();
            var playerTwoPokerHands = Deck.players[1].CalculatePokerHands();

            var playerOnesHighestPokerHand = playerOnePokerHands[0];
            var playerTwosHighestPokerHand = playerTwoPokerHands[0];

            foreach (var pokerHand in playerOnePokerHands)
            {
                if (pokerHand.CompareTo(playerOnesHighestPokerHand) > 0) playerOnesHighestPokerHand = pokerHand;
            }

            foreach (var pokerHand in playerTwoPokerHands)
            {
                if (pokerHand.CompareTo(playerTwosHighestPokerHand) > 0) playerTwosHighestPokerHand = pokerHand;
            }

            playerOnePokerCardOneLabel.Text = playerOnesHighestPokerHand.ToString();
            playerTwosPokerCardOneLabel.Text = playerTwosHighestPokerHand.ToString();


            PlayerOneRank.Text = ((PokerHand.Rank)playerOnesHighestPokerHand.getHandRank()).ToString();
            playerTwoRank.Text = ((PokerHand.Rank)playerTwosHighestPokerHand.getHandRank()).ToString();

            int comparison = playerOnesHighestPokerHand.CompareTo(playerTwosHighestPokerHand);
            if (comparison > 0) //player one has a higher rank
            {
                MessageBox.Show("The Round is Over, Player One had a higher ranking poker hand!", "Player One Has Won The Pot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Deck.players[0].money += Deck.ResetPotAndTableCards();
                ResetForNewGame();
            }
            else if (comparison < 0)
            {
                MessageBox.Show("The Round is Over, Player Two had a higher ranking poker hand!", "Player Two Has Won The Pot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Deck.players[1].money += Deck.ResetPotAndTableCards();
                ResetForNewGame();
            }
            else
            {
                MessageBox.Show("The Round is Over, Each Player Ranked The Same Amount, game ends in a tie", "Game Tied, Pot Split", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int splitPot = Deck.ResetPotAndTableCards() / 2;
                Deck.players[0].money += splitPot; Deck.players[1].money += splitPot;
                ResetForNewGame();
            }

        }
        private void ResetForNewGame()
        {
            playerOnesTurn = true;
            playerOnesPokerHandPanel.Visible = true;
            playerTwosPokerHandPanel.Visible = true;
            stageIndicator.Text = "Pre-Flop";

            UpdateUIInformation();
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            checkButton.Visible = false;

            if (playerOnesTurn)
            {
                Deck.PlayerBet(Deck.players[0]);
                Deck.players[0].bettingCurrentRound = true;
                playerOnesTurn = false;
                if (Deck.players[1].bettingCurrentRound) NextRound();

            }
            else
            {
                Deck.PlayerBet(Deck.players[1]);
                Deck.players[1].bettingCurrentRound = true;
                playerOnesTurn = true;
                if (Deck.players[0].bettingCurrentRound) NextRound();
            }
            UpdateUIInformation();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (Deck.players[0].bettingCurrentRound || Deck.players[1].bettingCurrentRound)
            {
                throw new InvalidOperationException("Cannot Check When Another Player Has Bet");
            }
            if (playerOnesTurn) playerOnesTurn = false;
            else playerOnesTurn = true;
            UpdateUIInformation();

        }



        private void foldButton_Click(object sender, EventArgs e)
        {
            if (playerOnesTurn)
            {
                MessageBox.Show("Player Two Has Won The Pot", "The Round is Over Due To Player One Folding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Deck.players[1].money += Deck.ResetPotAndTableCards();
                ResetForNewGame();
            }
            else
            {
                MessageBox.Show("Player One Has Won The Pot", "The Round is Over Due To Player Two Folding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Deck.players[0].money += Deck.ResetPotAndTableCards();
                ResetForNewGame();
            }


        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            playerOnesPokerHandPanel.Visible = false;
            playerTwosPokerHandPanel.Visible = false;

        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            int comparison = Deck.players[0].CompareTo(Deck.players[1]);
            if (comparison > 0) 
            {
                MessageBox.Show($"Player One Wins the Game with ${Deck.players[0].money}!", "Player One Wins", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (comparison < 0)
            {
                MessageBox.Show($"Player Two Wins the Game with ${Deck.players[1].money}!", "Player Two Wins", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show($"Both players Tied the Game with ${Deck.players[1].money}!", "Players Tied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Close();
        }
    }
}
