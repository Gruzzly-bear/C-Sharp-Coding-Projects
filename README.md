# C Sharp projects


### Introduction
This repository houses a load of test code I have worked on throughout my journey through C Sharp. Including a fully functional 21 Black jack application.

### Black Jack
- [BlackJack](https://github.com/Gruzzly-bear/C-Sharp-Coding-Projects/tree/master/basics/Casino)
#### Some neat features.

##### Deck creation

``` c#
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i <13; i++)
            {
                for (int j = 0; j <4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

        }
```
##### Dealer's Hand 

``` c#
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n"); 
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Faceb\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\TwentyOne\cardLog.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
```

##### Catching cheaters

``` c#
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only. No decimals.");
                }
                if (bet < 0)
                {
                    throw new FraudException("Security! Kick this person out!");
                 
                }
```
### Contact and links
- [Github](https://github.com/Gruzzly-bear)
- [Email](mailto:MB.Bowen@outlook.com?subject=Hey%20There!)
- [Website](https://gruzzly.co)
