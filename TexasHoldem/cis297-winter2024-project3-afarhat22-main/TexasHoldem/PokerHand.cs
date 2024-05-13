using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    internal class PokerHand : IComparable<PokerHand>
    {
        public List<Card> pokerHandCards { get; private set; }
        public enum Rank { HighCard, Pair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush } 

        public PokerHand(List<Card> cards) 
        {
            pokerHandCards = cards;
        }

        public int getHandRank()
        {
            if (StraightFlush()) return (int)Rank.StraightFlush;
            else if (FourOfAKind()) return (int)Rank.FourOfAKind;
            else if (FullHouse()) return (int)Rank.FullHouse;
            else if (Flush()) return (int)Rank.Flush;
            else if (Straight()) return (int)Rank.Straight;
            else if (ThreeOfAKind()) return (int)Rank.ThreeOfAKind;
            else if (TwoPair()) return (int)Rank.TwoPair;
            else if (Pair()) return (int)Rank.Pair;
            else return (int)Rank.HighCard;
        }

        private bool FourOfAKind()
        {
            foreach (Card currentCard in pokerHandCards)
            {
                if (pokerHandCards.Count(card => card.face == currentCard.face) == 4) { return true; }
            }

            return false;
        }

        private bool StraightFlush()
        {
            var suitOfFirstCard = pokerHandCards.First().suit;
            if (!pokerHandCards.All(card => card.suit == suitOfFirstCard)) { return false; }

            var cardsInOrder = pokerHandCards.OrderBy(card => card.face).ToList();
            int cardFaceValue = (int)cardsInOrder.First().face;
            for (int i = 0; i < cardsInOrder.Count - 1; i++)
            {
                var card = cardsInOrder[i];
                var nextCard = cardsInOrder[i+1];  
                if ((int)card.face + 1 != (int)nextCard.face)
                {
                    return false;
                }
            }
            return true;
        }

        private bool FullHouse()
        {
            //Asked UMGPT how i can seperate different groups into lists in a list of items, then had to specify im grouping by a specific attribute within the items.
            var groups = pokerHandCards.GroupBy(card => card.face)
                .Select(group => new {Face = group.Key, Count = group.Count()})
                .ToList();

            if (groups.Count == 2 && ((groups[0].Count == 3 && groups[1].Count == 2) || (groups[0].Count == 2 && groups[1].Count == 3)))
            {
                return true;
            }
            return false;
        }

        private bool Flush()
        {
            var firstCardSuit = pokerHandCards.First().suit;
            if (pokerHandCards.All(card => card.suit == firstCardSuit)) return true;
            return false;
        }

        private bool Straight()
        {
            var cardsInOrder = pokerHandCards.OrderBy(card => card.face).ToList();
            int cardFaceValue = (int)cardsInOrder.First().face;
            for (int i = 0; i < cardsInOrder.Count - 1; i++)
            {
                var card = cardsInOrder[i];
                var nextCard = cardsInOrder[i + 1];
                if ((int)card.face + 1 != (int)nextCard.face)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ThreeOfAKind()
        {
            var groups = pokerHandCards.GroupBy(card => card.face)
                .Select(group => new { Face = group.Key, Count = group.Count() })
                .ToList();

            foreach ( var cardGroup in groups) 
            {
                if (cardGroup.Count == 3) return true;
                
            }
            return false;
        }

        private bool TwoPair()
        {
            var groups = pokerHandCards.GroupBy(card => card.face)
                .Select(group => new { Face = group.Key, Count = group.Count() })
                .ToList();

            int pairCount = 0;

            foreach (var cardGroup in groups)
            {
                if (cardGroup.Count == 2) pairCount++;
            }
            if (pairCount == 2) return true;
            return false;
        }

        private bool Pair()
        {
            var groups = pokerHandCards.GroupBy(card => card.face)
                .Select(group => new { Face = group.Key, Count = group.Count() })
                .ToList();

            foreach (var cardGroup in groups)
            {
                if (cardGroup.Count == 2) return true;
            }
            return false;
        }



        public override string ToString()
        {
            string str = "";
            foreach (Card card in pokerHandCards)
            {
                str += card.ToString() + Environment.NewLine;
            }
            return str;
        }

        private int HighCardComparer(List<Card> playerOnesCards, List<Card> playerTwosCards)
        {
            if (playerOnesCards.Count != playerTwosCards.Count) throw new ArgumentException("Each Hand Should Consist of the same amount of cards");
            
            var sortedCardsOne = playerOnesCards.OrderByDescending(card => card.face).ToList();
            var sortedCardsTwo = playerTwosCards.OrderByDescending(card => card.face).ToList();

            for (int i = 0; i < sortedCardsOne.Count; i++)
            {
                int comparison = sortedCardsOne[i].CompareTo(sortedCardsTwo[i]);
                if (comparison != 0) return comparison;
            }
            return 0;
        }


        public int CompareTo(PokerHand? other)
        {
            if (this.getHandRank() == 0 &&  other.getHandRank() == 0)
            {
                return HighCardComparer(this.pokerHandCards, other.pokerHandCards);
            } else
            {
                return this.getHandRank() - other.getHandRank();
            }
        }
    }
}
