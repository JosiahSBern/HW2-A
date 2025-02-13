using Cards2;

// Deck deck = new Deck();
// deck.Shuffle();


// Card top;

// Console.WriteLine(top.Rank);
// Console.WriteLine(top.Suit);
// deck.Print();

// int even=0;
// int odd=0;

// for(int i = 0;i<5;i++){
//     top = deck.TakeTopCard();
//     Console.WriteLine(top.Rank);
//     // int rankValue = int(top.Rank);
//     // if( rankValue % 2 == 0){
//     //     even++;
//     // }
//     // else{
//     //     odd++;
//     // }
//     Console.WriteLine($"{top.Suit}\n");


//     // Console.WriteLine($"There are {even} even numbers \n {odd} odds") ;
// }



// loop while there's more input
// string input = Console.ReadLine();

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck d1 = new Deck();
Console.WriteLine("Dealing Cards:");

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
Card[] player1 = new Card[2];
Card[] player2 = new Card[3];
Card[] player3 = new Card[3];
Card[] player4 = new Card[2];


Card[][] players = [player1,player2,player3,player4];
for(int i = 0;i<2;i++){
    for(int k = 0;k<4;k++){
        Console.WriteLine($"    Dealing Card {i+1} to Player {k+1}");
        players[k][i] = d1.TakeTopCard();
    }
}





// deal 1 more card to players 2 and 3
player2[2] = d1.TakeTopCard();
player3[2] = d1.TakeTopCard();
// flip all the cards over
foreach(var player in players){
    foreach(Card card in player){
        card.FlipOver();
    }
}

// print the cards for player 1
Console.WriteLine("Player 1's Cards: ");
foreach(Card card1 in player1){
    string status = card1.FaceUp ? "Flipped" : "Faced Down"; 
    Console.WriteLine($"  {card1.Rank},{card1.Suit} is {status}");
}

// print the cards for player 2
Console.WriteLine("Player 2's Cards: ");
foreach(Card card1 in player2){
    string status = card1.FaceUp ? "Flipped" : "Faced Down"; 
    Console.WriteLine($"  {card1.Rank},{card1.Suit} is {status}");
}

// print the cards for player 3
Console.WriteLine("Player 3's Cards: ");
foreach(Card card1 in player3){
    string status = card1.FaceUp ? "Flipped" : "Faced Down"; 
    Console.WriteLine($"  {card1.Rank},{card1.Suit} is {status}");
}

// print the cards for player 4
Console.WriteLine("Player 4's Cards: ");
foreach(Card card1 in player4){
    string status = card1.FaceUp ? "Flipped" : "Faced Down"; 
    Console.WriteLine($"  {card1.Rank},{card1.Suit} is {status}");
}
