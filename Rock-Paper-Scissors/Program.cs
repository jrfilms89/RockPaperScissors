using System;

namespace Rock_Paper_Scissors {
    class Program {
        static void Main(string[] args) {

            var weapon = new string[] { "rock", "paper", "scissors" };
            var player1 = "";
            var player2 = 0;
            var playing = false;
            Random rand = new Random();
            Console.WriteLine("********************************");
            Console.WriteLine("Choose Rock, Paper, or Scissors");
            Console.WriteLine("********************************");

            do {
                Console.Write("Choose your weapon : ");
                player1 = Console.ReadLine().ToLower();
                if (player1 == "rock" || player1 == "paper" || player1 == "scissors") {
                    switch (player1) {
                        case "rock":
                            player2 = rand.Next(weapon.Length);
                            Console.WriteLine($"Computer randomly chooses : {weapon[player2]}");
                            if (player2 == 0) {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("DRAW!!");
                                Console.ResetColor();
                            }
                            if (player2 == 1) {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("YOU LOSE!!");
                                Console.ResetColor();
                            }
                            if (player2 == 2) {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("YOU WIN!!");
                                Console.ResetColor();
                            }
                            break;
                        case "paper":
                            player2 = rand.Next(weapon.Length);
                            Console.WriteLine($"Computer randomly chooses : {weapon[player2]}");
                            if (player2 == 0) {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("YOU WIN!!");
                                Console.ResetColor();
                            } else if (player2 == 1) {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("DRAW!!");
                                Console.ResetColor();
                            } else if (player2 == 2) {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("YOU LOSE!!");
                                Console.ResetColor();
                            }
                            break;
                        case "scissors":
                            player2 = rand.Next(weapon.Length);
                            Console.WriteLine($"Computer randomly chooses : {weapon[player2]}");
                            if (player2 == 0) {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.ResetColor();
                            } else if (player2 == 1) {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("YOU WIN!!");
                                Console.ResetColor();
                            } else if (player2 == 2) {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("DRAW!!");
                                Console.ResetColor();
                            }
                            break;
                    }
                    Console.WriteLine("Do you want to play again? Y or N");
                    var again = Console.ReadLine().ToLower();
                    switch (again) {
                        case "y":
                            playing = true;
                            break;
                        case "n":
                            playing = false;
                            break;
                        default:
                            Console.WriteLine("You entered a wrong number");
                            break;
                    }
                    } else {
                    Console.WriteLine("Invalid weapon. Try again.");
                    playing = true;
                }
            } while (playing);

        }
    }
}
