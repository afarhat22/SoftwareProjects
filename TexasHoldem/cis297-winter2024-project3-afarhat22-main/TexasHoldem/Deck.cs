using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    internal static class Deck
    {
        public static List<Card> deck { get; private set; } = new List<Card>();
        public static Card[] tableCards { get; private set; } = new Card[5];
        public static int pot { get; private set; } = 0;
        public static List<HoldemHand> players { get; private set; } = new List<HoldemHand>();

        public static void ResetDeck()
        {

            for (int Suit = 0; Suit < 4; Suit++)
            {
                for (int Face = 0; Face < 13; Face++)
                {
                    deck.Add(new Card((Card.Face)Face, (Card.Suit)Suit));
                }
            }

            //Remove Cards already on table and in player HoldemHands from deck to prevent duplicates
            if(deck.Count > 52)
            {
                deck.Remove(players[0].playerCards[0]);
                deck.Remove(players[0].playerCards[1]);

                deck.Remove(players[1].playerCards[0]);
                deck.Remove(players[1].playerCards[1]);

                foreach (Card card in tableCards)
                {
                    deck.Remove(card);
                }
            }
            



            //Showed ChatGPT the current code and asked how we could shuffle the deck
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = new Random().Next(n + 1); // Random integer between 0 and n
                (deck[n], deck[k]) = (deck[k], deck[n]);
            }
        }

        public static int ResetPotAndTableCards()
        {
            Array.Fill(tableCards, null);
            int potValue = pot;
            
            pot = 0;
            return potValue;
        }
        
        
        public static void PlayerBet(HoldemHand player)
        {
            player.money--;
            pot++;
        }
        public static void InitializePlayers()
        {
            players.Add(new HoldemHand("Player 1"));
            players.Add(new HoldemHand("Player 2"));
        }
        public static Card PullCard()
        {
            if (deck.Count > 0)
            {
                Card pulledCard = deck[0];
                deck.RemoveAt(0);
                return pulledCard;

            }
            else
            {
                ResetDeck();
                return PullCard();
                
            }
        }

        /*
         * Add's a new card to community cards or resets the community cards depending
         * on the current number of cards. 
         */
        public static void UpdateTableCardsForNextRound()
        {
            players[0].bettingCurrentRound = false;
            players[1].bettingCurrentRound = false;

            if (tableCards[0] is null)
            {
                tableCards[0] = PullCard();
                tableCards[1] = PullCard();
                tableCards[2] = PullCard();
                
            }
            else if (tableCards[3] is null)
            {
                tableCards[3] = PullCard(); 
            } else if (tableCards[4] is null)
            {
                tableCards[4] = PullCard();
            } 
            
        }
    }
}
