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

### Contact and links
- [Github](https://github.com/Gruzzly-bear)
- [Email](mailto:MB.Bowen@outlook.com?subject=Hey%20There!)
- [Website](https://gruzzly.co)
