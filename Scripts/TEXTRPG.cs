using System;

namespace TEXTRPG
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }
        struct Player
        {
            public int hp;
            public int attack;
        }

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }

        struct Monster
        {
            public int hp;
            public int attack;
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 골라라");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
                default:
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임 스폰!");
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크 스폰!");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤 스폰!");
                    monster.hp = 30;
                    monster.attack = 3;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
        }

        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("마을에 접속!");
                Console.WriteLine("[1] 필드");
                Console.WriteLine("[2] 로비");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    EnterField(ref player);
                }
                else if (input == "2")
                {
                    break;
                }
            }
          
        }

        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속");

                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투");
                Console.WriteLine("[2] 도망");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Fight(ref player, ref monster);
                }
                else if (input == "2")
                {
                    // 도망 성공 확률 40%
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if (randValue <= 40)
                    {
                        Console.WriteLine("도망!");
                        player.hp = 100;
                        break;
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }
            }
        }

        static void Fight(ref Player player, ref Monster monster)
        {
            while (true)
            {
                monster.hp -= player.attack;
                if(monster.hp <= 0)
                {
                    Console.WriteLine("승리");
                    Console.WriteLine($"체력 : {player.hp}");
                    break;
                }

                player.hp -= monster.attack;
                if (player.hp <= 0)
                {
                    Console.WriteLine("사망");
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ClassType choice = ChooseClass();

                if (choice == ClassType.None)
                {
                    continue;
                }

                Player player;
                CreatePlayer(choice, out player);

                Console.WriteLine($"HP : {player.hp} Attack : {player.attack}");
                EnterGame(ref player);
                
            }
        }
    }
}

