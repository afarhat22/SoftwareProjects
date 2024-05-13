using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    internal class HoldemHand : IComparable<HoldemHand>
    {
        public string playerName { get; private set; }
        public enum Ranks { highCard, onePair, twoPair, threeOfAKind, straight, flush, fourOfAKind, straightFlush };
        public Card[] playerCards {  get; private set; }
        public int money { get;  set; }
        public bool bettingCurrentRound { get; set; }

        public HoldemHand(string name)
        {
            playerName = name;
            bettingCurrentRound = false;
            playerCards = new Card[2];
            playerCards[0] = Deck.PullCard();
            playerCards[1] = Deck.PullCard();
            money = 100;
        }

        public List<PokerHand> CalculatePokerHands()
        {
            List <Card> cards = []; //The Seven Cards We Can Create Hands From
            List <PokerHand> pokerHandCombinations = [];
            cards.AddRange(playerCards);
            cards.AddRange(Deck.tableCards.Where(card => card != null));
            
            if (cards.Count == 7)
            {
                var combinations = GenerateCombinations(cards, 5);

                foreach (var cardCombo in combinations) 
                {
                    pokerHandCombinations.Add(new PokerHand(cardCombo));
                }
            } else
            {
                throw new Exception("Size Of cards should be 7");
            }

            return pokerHandCombinations;
        }

        /*Presented ChatGPT with the current code and explained that I needed a way to generate 21 combinations from the 7 that I have, each of size 5. 
         * ChatGPT gave the following:
         */

        // Method to generate combinations of cards
        private IEnumerable<List<Card>> GenerateCombinations(List<Card> cards, int combinationSize)
        {
            // Base case: if combination size is 0, return empty list
            if (combinationSize == 0)
            {
                yield return new List<Card>();
            }
            // Base case: if combination size is equal to number of cards, return all cards
            else if (combinationSize == cards.Count)
            {
                yield return cards;
            }
            // Base case: if only one card is needed in the combination
            else if (combinationSize == 1)
            {
                foreach (var card in cards)
                {
                    yield return new List<Card> { card };
                }
            }
            else
            {
                // Recursive case: generate combinations
                for (int i = 0; i < cards.Count; i++)
                {
                    Card currentCard = cards[i];
                    List<Card> remainingCards = cards.Skip(i + 1).ToList();

                    foreach (var combination in GenerateCombinations(remainingCards, combinationSize - 1))
                    {
                        combination.Insert(0, currentCard);
                        yield return combination;
                    }
                }
            }
        }

        public int CompareTo(HoldemHand? other)
        {
            //returns the difference of money for each player
            return this.money - other.money;
        }
    }
}
