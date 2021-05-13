using System;

namespace _0513
{
    #region
    //class Player
    //{
    //    protected int hp;
    //    protected int attack;

    //    public virtual void Move()
    //    {
    //        Console.WriteLine("Player Move!");
    //    }
    //}

    //// 오버로딩 : 함수 이름의 재사용
    //// void Test(){} / void Test(int a){}
    //// 오버라이딩 : 다형성 이용

    //class Knight : Player
    //{
    //    public override void Move()
    //    {
    //        base.Move();
    //        Console.WriteLine("Knight Run!");
    //    }
    //}

    //class DeathKnight : Knight
    //{
    //    public override void Move()
    //    {
    //        Console.WriteLine("DeathKnight Move!");
    //    }
    //}

    //class Mage : Player
    //{
    //    public int mp;

    //    public override void Move()
    //    {
    //        Console.WriteLine("Mage Teleport!");
    //    }
    //}
    #endregion // 접음

    class Program
    {
        #region
        //enum Choice
        //{
        //    Rock = 1,
        //    Paper = 2,
        //    Scissors = 0
        //}

        // 한정자 반환형식 이름(매개변수)
        // {
        // }

        //static void HelloWorld()
        //{
        //    Console.WriteLine("Hello World!");
        //}

        //static int Add(int a, int b)
        //{
        //    int result = a + b;
        //    return result;
        //}

        //static void AddOne(ref int number)
        //{
        //    number++;
        //}
        //static int AddOne2(int number)
        //{
        //    return number + 1;
        //}

        //static void Swap(ref int a,ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    a = temp;
        //}

        //static void Divide(int a, int b, out int result1, out int result2)
        //{
        //    result1 = a / b;
        //    result2 = a % b;
        //}

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Add(int a, int b, int c = 0, int d = 0)
        //{
        //    return a + b + c + d;
        //}

        //static float Add(float a, float b)
        //{
        //    return a + b;
        //}

        //static int Factorial(int n)
        //{
        //    if (n <= 1)
        //        return 1;
        //    return n * Factorial(n - 1);

        //int ret = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    ret *= i;
        //}
        //return ret;
        //}


        //static void Print(int value)
        //{
        //    Console.WriteLine(value);
        //}

        //static int AddandPrint (int a, int b)
        //{
        //    int ret = a + b;
        //    Print(ret);
        //    return ret;
        //}

        //enum ClassType
        //{
        //    None = 0,
        //    Knight = 1,
        //    Archer = 2,
        //    Mage = 3
        //}

        //struct Player
        //{
        //    public int hp;
        //    public int attack;
        //}

        //enum MonsterType
        //{
        //    None = 0,
        //    Slime = 1,
        //    Orc = 2,
        //    Skeleton = 3
        //}

        //struct Monster
        //{
        //    public int hp;
        //    public int attack;
        //}

        //static ClassType ChooseClass()
        //{
        //    Console.WriteLine("직업을 골라라");
        //    Console.WriteLine("[1] 기사");
        //    Console.WriteLine("[2] 궁수");
        //    Console.WriteLine("[3] 법사");

        //    ClassType choice = ClassType.None;
        //    string input = Console.ReadLine();

        //    switch (input)
        //    {
        //        case "1":
        //            choice = ClassType.Knight;
        //            break;
        //        case "2":
        //            choice = ClassType.Archer;
        //            break;
        //        case "3":
        //            choice = ClassType.Mage;
        //            break;
        //        default:
        //            break;
        //    }

        //    return choice;
        //}

        //static void CreatePlayer(ClassType choice, out Player player)
        //{
        //    switch (choice)
        //    {
        //        case ClassType.Knight:
        //            player.hp = 100;
        //            player.attack = 10;
        //            break;
        //        case ClassType.Archer:
        //            player.hp = 75;
        //            player.attack = 12;
        //            break;
        //        case ClassType.Mage:
        //            player.hp = 50;
        //            player.attack = 15;
        //            break;
        //        default:
        //            player.hp = 0;
        //            player.attack = 0;
        //            break;
        //    }
        //}

        //static void CreateRandomMonster(out Monster monster)
        //{
        //    Random rand = new Random();
        //    int randMonster = rand.Next(1, 4);
        //    switch (randMonster)
        //    {
        //        case (int)MonsterType.Slime:
        //            Console.WriteLine("슬라임 스폰!");
        //            monster.hp = 20;
        //            monster.attack = 2;
        //            break;
        //        case (int)MonsterType.Orc:
        //            Console.WriteLine("오크 스폰!");
        //            monster.hp = 40;
        //            monster.attack = 4;
        //            break;
        //        case (int)MonsterType.Skeleton:
        //            Console.WriteLine("스켈레톤 스폰!");
        //            monster.hp = 30;
        //            monster.attack = 3;
        //            break;
        //        default:
        //            monster.hp = 0;
        //            monster.attack = 0;
        //            break;
        //    }
        //}

        //static void Fight(ref Player player, ref Monster monster)
        //{
        //    while (true)
        //    {
        //        // 플레이어가 몬스터 공격
        //        monster.hp -= player.attack;
        //        if (monster.hp <= 0)
        //        {
        //            Console.WriteLine("승리!");
        //            Console.WriteLine($"체력 : {player.hp}");
        //            break;
        //        }

        //        // 몬스터가 반격
        //        player.hp -= monster.attack;
        //        if (player.hp <= 0)
        //        {
        //            Console.WriteLine("사망!");
        //            break;
        //        }
        //    }
        //}

        //static void EnterField(ref Player player)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("필드에 접속했습니다");

        //        // 몬스터 생성
        //        Monster monster;
        //        CreateRandomMonster(out monster);

        //        Console.WriteLine("[1] 전투");
        //        Console.WriteLine("[2] 일정 확률로 마을로 도망");

        //        string input = Console.ReadLine();
        //        if (input == "1")
        //        {
        //            Fight(ref player, ref monster);
        //        }
        //        else if (input == "2")
        //        {
        //            // 도망 성공 확률 40%
        //            Random rand = new Random();
        //            int randValue = rand.Next(0, 101);
        //            if (randValue <= 40)
        //            {
        //                Console.WriteLine("도망!");
        //                player.hp = 100;
        //                break;
        //            }
        //            else
        //            {
        //                Fight(ref player, ref monster);
        //            }
        //        }
        //    }

        //}

        //static void EnterGame(ref Player player)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("마을에 접속했습니다!");
        //        Console.WriteLine("[1] 필드로 간다");
        //        Console.WriteLine("[2] 로비로 돌아가기");

        //        string input = Console.ReadLine();
        //        if (input == "1")
        //        {
        //            EnterField(ref player);
        //        }
        //        else if (input == "2")
        //        {
        //            break;
        //        }


        //    }
        //}


        // 객체(OOP Object Oriented Programming)

        // Knight

        // 속성 : hp, attack
        // 기능 : Move, Attack, Die

        // Ref 원본

        //class Player // 부모 클래스 혹은 기반 클래스
        //{
        //    // 필드
        //    static public int counter = 1; // 오로지 1개만 존재! Knight에 종속적인 변수

        //    public int id;
        //    public int hp;
        //    public int attack;

        //public Player()
        //{
        //    Console.WriteLine("Player 생성자 호출!");
        //}
        //public Player(int hp)
        //{
        //    this.hp = hp;
        //    Console.WriteLine("Player hp 생성자 호출!");
        //}
        //    public void Move()
        //    {
        //        Console.WriteLine("Player Move");
        //    }

        //    public void Attack()
        //    {
        //        Console.WriteLine("Player Attack");
        //    }
        //}

        //class Mage : Player
        //{

        //}
        //class Archer : Player
        //{

        //}

        //class Knight : Player // 자식 클래스 혹은 파생 클래스
        //{
        //    public void Stun()
        //    {

        //    }

        //int c;
        //public Knight() : base(100)
        //{
        //    this.c = 10;
        //    base.hp = 1000;
        //    Console.WriteLine("Knight 생성자 호출!");
        //}


        //static public Knight CreateKnight()
        //{
        //    Knight knight = new Knight();
        //    knight.hp = 20;
        //    knight.attack = 2;
        //    return knight;
        //}
        //static public void Test()
        //{
        //    counter++;
        //}

        //public Knight()
        //{
        //    id = counter;
        //    counter++;
        //    hp = 100;
        //    attack = 10;
        //    Console.WriteLine($"생성자 호출!  {hp}, {attack}");
        //}

        //public Knight(int hp) // : this()
        //{
        //    this.hp = hp;
        //    Console.WriteLine($"int 생성자 호출!  {hp}, {attack}");

        //}

        //public Knight(int hp, int attack) // : this(hp)
        //{
        //    this.hp = hp;
        //    this.attack = attack;
        //    Console.WriteLine($"int 생성자! {hp}, {attack}");

        //}

        //public Knight Clone()
        //{
        //    Knight knight = new Knight();
        //    knight.hp = hp;
        //    knight.attack = attack;
        //    return knight;
        //}


        //}

        //// Copy 복사
        //struct Mage
        //{
        //    public int hp;
        //    public int attack;
        //}

        //static void KillMage(Mage mage)
        //{
        //    mage.hp = 0;
        //}

        //static void KillKnight(Knight knight)
        //{
        //    knight.hp = 0;
        //}

        // 은닉성
        // 자동차 
        // 핸들 페달 차문
        // 전기장치 엔진 기름 <-> 외부 노출

        //class Knight
        //{
        //    // 접근 한정자
        //       // public protected private
        //    protected int hp;
        //    private int attack;

        //    public void SetAttack(int attack)
        //    {
        //        this.attack = attack;
        //    }
        //}

        //class DeathKnight : Knight
        //{
        //    void Test()
        //    {
        //        hp = 10;
        //    }
        //}

        //static Player FindPlayerById(int id)
        //{
        //    // id 에 해당하는 플레이어를 탐색

        //    // 못찾으면
        //    return null;
        //}

        //static void EnterGame(Player player)
        //{
        //bool isMage = (player is Mage);
        //if (isMage)
        //{
        //    Mage mage = (Mage)player;
        //    mage.mp = 10;
        //}
        //player.Move();

        //    Mage mage = (player as Mage);
        //    if (mage != null)
        //    {
        //        mage.mp = 10;
        //        mage.Move();
        //    }
        //}

        #endregion

        static void Main(string[] args)
        {
            #region
            /* 0511 */

            // ctrl c u
            //// 1. 바구니 크기가 다른 경우
            //int a = 0x0FFFFFF;
            //short b = (short)a;

            //// 2. 바구니 크기는 같긴 한데, 부호가 다를 경우

            //byte c = 255;
            //sbyte sb = (sbyte)c;

            //// 3. 소수
            //float f = 3.1414f;
            //double d = f;

            //int hp = 100;
            //int level = 1000;

            //// + - * / %
            //// < <= > >= == !=
            //hp = 100 % 3;

            //Console.WriteLine(++hp);

            //bool b = hp < 100;
            //bool IsAlive = (hp > 0);
            //bool IsHighLevel = (level > 100);

            //// a는 살아있는 고렙 유저인가요?
            //bool a = IsAlive && IsHighLevel;
            //bool c = !IsAlive;

            //Console.WriteLine(a);
            //Console.WriteLine(c);


            //// 비트 연산
            //int id = 123;
            //int key = 401;

            //int a = id ^ key;
            //int b = a ^ key;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //uint num = 1;

            //// << >> & |(or) ^(xor) 같지 않으면 1출력 ~(not)
            //num = num << 1;

            //Console.WriteLine(num);

            //int a ;
            //a = 100;

            //int b;
            //b = a;

            //a = a + 1;

            /* 0512 */

            //int hp = 100;
            //bool isDead = (hp <= 0);

            //if (isDead)
            //{
            //    Console.WriteLine("You are dead!");
            //    Console.WriteLine("You are dead!");
            //    Console.WriteLine("You are dead!");
            //}
            //else
            //{
            //    Console.WriteLine("You are alive!");
            //}

            //if (!isDead)
            //{
            //    Console.WriteLine("You are alive!");

            //}

            //int choice = 0; // 0 가위 1 바위 2 보

            //switch(choice)
            //{
            //    case 0:
            //        Console.WriteLine("가위입니다");
            //        break;
            //    case 1:
            //        Console.WriteLine("바위입니다");
            //        break;
            //    case 2:
            //        Console.WriteLine("보입니다");
            //        break;
            //    default:
            //        Console.WriteLine("에러");
            //        break;
            //}

            //if (choice == 0)
            //{
            //    Console.WriteLine("가위입니다");
            //}
            //else if (choice == 1)
            //{
            //    Console.WriteLine("바위입니다");
            //}
            //else
            //{
            //    Console.WriteLine("보입니다");
            //}

            // 삼항연산자

            //int number = 25;
            ////bool IsPair = (조건 ? 맞을때 : 틀릴때);

            //bool IsPair = ((number % 2) == 0 ? true : false);

            //if ((number % 2) == 0)
            //{
            //    IsPair = true;
            //}

            //int ROCK = 1;
            //int PAPER = 2;
            //int SCISSORS = 0;

            //// 0 가위 1 바위 2 보

            //Random rand = new Random();

            //int aiChoice = rand.Next(0, 3); // 0 ~ 2 사이 랜덤 값

            //int choice = Convert.ToInt32(Console.ReadLine());
            //int result;

            //switch (choice)
            //{
            //    case (int)Choice.Scissors :
            //        Console.WriteLine("당신의 선택은 가위입니다.");
            //        break;
            //    case (int)Choice.Rock:
            //        Console.WriteLine("당신의 선택은 바위입니다.");
            //        break;
            //    case (int)Choice.Paper:
            //        Console.WriteLine("당신의 선택은 보입니다.");
            //        break;
            //}

            //switch (aiChoice)
            //{
            //    case (int)Choice.Scissors:
            //        Console.WriteLine("컴퓨터의 선택은 가위입니다.");
            //        break;
            //    case (int)Choice.Rock:
            //        Console.WriteLine("컴퓨터의 선택은 바위입니다.");
            //        break;
            //    case (int)Choice.Paper:
            //        Console.WriteLine("컴퓨터의 선택은 보입니다.");
            //        break;
            //}

            //// 승리 무승부 패배

            //if (choice == aiChoice)
            //{
            //    Console.WriteLine("무");
            //}
            //else if ((choice - aiChoice == 1) || ((choice == 0) && (aiChoice == 2)))
            //{
            //    Console.WriteLine("승리");
            //}
            //else 
            //{
            //    Console.WriteLine("패배");
            //}

            //string answer;

            //do
            //{
            //    Console.WriteLine("당신은 사람인가요 (Y/N) : ");
            //    answer = Console.ReadLine();

            //} while (answer != "Y");
            //{
            //    Console.WriteLine("사람이군");
            //}

            //for (초기화식; 조건식; 반복식)
            //{

            //}

            //int num = 97;

            //bool IsPrime = true;

            //for (int i = 2; i < num; i++)
            //{
            //    if ((num % i) == 0)
            //    {
            //        IsPrime = false;
            //        Console.WriteLine("소수가 아닙니다!");
            //        break;
            //    }
            //    Console.WriteLine("소수!");
            //    break;

            //    //// 특정 조건`
            //    //break;
            //    //Console.WriteLine("Hello World");
            //}

            //if (IsPrime)
            //    Console.WriteLine("소수!!");
            //else
            //    Console.WriteLine("소수가 아닙니다!!");


            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 3) != 0)
            //    {
            //        continue;
            //        Console.WriteLine($"3으로 나뉘는 숫자 : {i}");
            //    }
            //}

            //HelloWorld();
            //Program.HelloWorld();
            //Console.WriteLine(Program.Add(5, 6));
            //int result = Program.Add(5, 6);

            //int a = 4;
            //int b = 5;
            //Console.WriteLine(Add(4, 5));

            //Console.WriteLine(result);

            //int c = 0;
            //Program.AddOne(ref c);
            //Console.WriteLine(c);

            //int a = 0;
            //Program.AddOne(ref a);
            //Console.WriteLine(a);

            //a = Program.AddOne2(a);
            //Console.WriteLine(a);

            //int num1 = 1;
            //int num2 = 200;

            //Program.Swap(ref num1, ref num2);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //int num1 = 10;
            //int num2 = 3;

            //int result1;
            //int result2;

            //Divide(10, 3, out result1, out result2);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);


            //int ret = Program.Add(4, 5);
            //float ret2 = Program.Add(3.0f, 5.0f);
            //int ret3 = Program.Add(4, 5, 6);


            //Console.WriteLine(ret);
            //Console.WriteLine(ret2);
            //Console.WriteLine(ret3);

            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        //string ii = i.ToString();
            //        //string jj = j.ToString();
            //        //int result = i * j;
            //        //Console.WriteLine(ii + "x" + jj +" = " + result);

            //        Console.WriteLine($"{i} * {j} = {i * j}");

            //    }
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int ret = Factorial(5);
            //Console.WriteLine(ret);

            // 0512
            //Program.AddandPrint(1, 2);
            //Program.AddandPrint(3, 4);
            //Program.AddandPrint(10, 20);


            //while (true)
            //{
            //    ClassType choice = ChooseClass();

            //    if (choice == ClassType.None)
            //    {
            //        continue;
            //    }

            //    // 캐릭터 생성
            //    Player player;
            //    CreatePlayer(choice, out player);

            //    // 기사(100/10) 궁수(75/12) 법사(50/15)
            //    Console.WriteLine($"HP : {player.hp} Attack : {player.attack}");
            //    EnterGame(ref player);

            //    // 필드 전투
            //}

            // 0513

            //Mage mage;
            //mage.hp = 50;
            //mage.attack = 15;
            ////KillMage(mage);

            //Mage mage2 = mage;
            //mage2.hp = 0;

            //knight.hp = 100;
            //knight.attack = 10;

            //knight.Move();
            //knight.Attack();
            ////KillKnight(knight);

            //Knight knight2 = knight.Clone();
            //knight2.hp = 0;

            //Knight knight = new Knight();
            //Knight knight2 = new Knight(50);
            //knight2.hp = 80;
            //Knight knight3 = new Knight(10, 1);
            //knight3.attack = 15;

            //Knight knight = Knight.CreateKnight(); // static
            //// knight.Move(); // 일반


            //Console.WriteLine(); // static
            //Random rand = new Random(); // 일반
            //rand.Next(0, 2);

            //Knight knight = new Knight();
            //knight.Move();

            //Knight knight = new Knight();
            //knight.SetAttack(100);

            //Knight knight = new Knight();
            //Mage mage = new Mage();
            //DeathKnight deathKnight = new DeathKnight();

            ////Player p1 = knight;

            ////Player magePlayer = mage;
            ////Mage mage2 = (Mage)magePlayer;

            ////EnterGame(knight);

            //knight.Move();
            //deathKnight.Move();

            ////mage.Move();

            //EnterGame(mage);

            #endregion

            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry"); // true
            int index = name.IndexOf('P'); // 6

            // 2. 변형
            name = name + " Junior";

            string lowerCaseName = name.ToLower();
            string upperCaseName = name.ToUpper();
            string newName = name.Replace('r', 'l');

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(2);

        }

    }
}

