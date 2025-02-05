using System;


class Program
{
    //게임 시작
    static void Main()
    {

        int Lv = 1;
        string chad = "전사";
        int attackPoint = 10;
        int guardPoint = 5;
        int HP = 100;
        int gold = 1500;

        while (true) //올바르지 않은 값 걸러내기
        {

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");

            string inTown = Console.ReadLine();
            if (int.TryParse((inTown), out int intinTown) == true)
            {
                int intInTown = int.Parse(inTown);
                if ((intInTown < 1) || (intInTown > 3))
                {
                    Console.WriteLine("잘못된 입력입니다.\n올바른 값을 입력해주세요.");
                    continue;
                }
                else if(intinTown == 1) //상태보기(1번)
                {
                    Console.WriteLine("Lv. " + Lv);
                    Console.WriteLine("chad. " + chad);
                    Console.WriteLine("공격력 : " + attackPoint);
                    Console.WriteLine("방어력 : " + guardPoint);
                    Console.WriteLine("체력 : " + HP);
                    Console.WriteLine("Gold : " + gold + "G");
                    Console.WriteLine("0 입력 : 나가기");

                    Console.WriteLine("원하시는 행동을 입력해주세요");
                    Console.Write(">>");
                    string exitcondition = Console.ReadLine();

                    while (true)//상태창에서 나가기
                    {
                        if (exitcondition == "0") 
                        { 
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("잘못된 입력입니다.\n올바른 값을 입력해주세요.");
                            Console.Write(">>");
                            exitcondition = Console.ReadLine();
                        }
                    }
                    
                }
                else { break; }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.\n올바른 값을 입력해주세요.");
                continue;
            }
        }
    }
}
