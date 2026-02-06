using System;

namespace Project
{
    class fighter_game
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string start;
            string pname;
            int player_HP = 0;
            int player_attack = 0;
            int player_healing = 0;

            Console.WriteLine("Welcome to: Hero Simulator");
            Console.WriteLine("");
            Console.Write("If you want to play press s to start or q to quit: ");
            start = Console.ReadLine();
            if (start != "s")
            {
                return;
            }
            Console.Write("What is your hero's name? ");
            pname = Console.ReadLine();
            Console.WriteLine("Hello, " + pname);
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("What type of hero is " + pname + ": ");
            Console.WriteLine("press 1 for the basic hero with 20 health");
            Console.WriteLine("press 2 for the tank hero with 35 health");
            Console.WriteLine("press 3 for the crit hero with 15 health");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            string choiceP = Console.ReadLine();
            if (choiceP == "1")
            {
                player_HP = 20;
                player_healing = 10;
                Console.WriteLine(pname + " is a basic hero");
            }
            else if (choiceP == "2")
            {
                player_HP = 35;
                player_healing = 5;
                Console.WriteLine(pname + " is a tank hero");
            }
            else if (choiceP == "3")
            {
                player_HP = 15;
                player_healing = 10;
                Console.WriteLine(pname + " is a crit hero");
            }

            int enemy_HP = 0;
            int enemy_attack = 0;
            int enemy_healing = 0;
            string ename = "";

            Console.WriteLine(" ");
            Console.WriteLine("Which enemy do you what to face: ");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("press 1 for a easy enemy");
            Console.WriteLine("press 2 for a normal enemy");
            Console.WriteLine("press 3 for a hard enemy");
            Console.WriteLine("press 4 for a boss enemy");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            string choiceE = Console.ReadLine();
            if (choiceE == "1")
            {
                ename = "slime";
                enemy_HP = 25;
                enemy_healing = 5;
                Console.WriteLine(pname + " is fighting a slime ~(0 0)~");
                Console.WriteLine("--------------------------------------------------------------------------------------");

            }
            else if (choiceE == "2")
            {
                ename = "Skelton Soldier";
                enemy_HP = 50;
                enemy_healing = 5;
                Console.WriteLine(pname + " is fighting a Skelton Soldier (*#*)");
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }
            else if (choiceE == "3")
            {
                ename = "Barbarian King";
                enemy_HP = 75;
                enemy_healing = 10;
                Console.WriteLine(pname + " is fighting a Barbarian King WVW");
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }
            else if (choiceE == "4")
            {
                ename = "The Dragon";
                enemy_HP = 100;
                enemy_healing = 10;
                Console.WriteLine(pname + " is fighting a Dragon (`^0<~~");
                Console.WriteLine("--------------------------------------------------------------------------------------");
            }


            while (player_HP > 0 && enemy_HP > 0)
            {
                Console.WriteLine(pname + " HP - " + player_HP);
                Console.WriteLine(ename + " HP - " + enemy_HP);
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("--" + pname + " turn--");
                Console.WriteLine("Press a to attack or h to heal");
                string action = Console.ReadLine();
                if (action == "a")
                {
                    player_attack = rnd.Next(1, 21);
                    enemy_HP -= player_attack;
                    Console.WriteLine(pname + " did these amount " + player_attack);
                }
                else if (action == "h")
                {
                    player_HP += player_healing;
                    Console.WriteLine(" ");
                    Console.WriteLine(pname + " healed " + player_healing + " points");
                }

                if (enemy_HP > 0)
                {
                    Console.WriteLine(pname + " HP - " + player_HP);
                    Console.WriteLine(ename + " HP - " + enemy_HP);
                    Console.WriteLine(" ");
                    Console.WriteLine("--" + ename + " turn--");
                    int enemy_action = rnd.Next(0, 2);
                    if (enemy_action == 0)
                    {
                        enemy_attack = rnd.Next(1, 26);
                        player_HP -= enemy_attack;
                        Console.WriteLine(ename + " did these amount " + enemy_attack);
                    }
                    else if (enemy_action == 1)
                    {
                        enemy_HP += enemy_healing;
                        Console.WriteLine(" ");
                        Console.WriteLine(ename + " healed " + enemy_healing + " points");
                    }
                }
            }
            if (player_HP > 0)
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine(ename + " won");
                Console.WriteLine("Game Over");
            }

        }// end of main
    }//end program
}