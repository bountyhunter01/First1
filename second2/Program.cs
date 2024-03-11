using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//c#은 클래스의 노예이다
//모든 길은 클래스로 통한다.


class Player
{//public 안해놓으면 private 가 기본값
    //일반적으로 private해놓아야 좋음
    public int Damage;
    public int Hp;
    public int Att;
    public int Df;
    public int MonsterHp = 10; // 몬스터의 체력을 추가

    public void Fight()
    {
        Random random = new Random();

        while (true)
        {
            bool isDefend = random.NextDouble() < 0.52; // 방어 랜덤 숫자
            bool isAtt = random.NextDouble() < 0.38; // 공격 랜덤 숫자

            if (isDefend)
            {
                Console.WriteLine("방어에 성공했습니다");
            }
            else
            {
                Hp -= Damage;

                if (Hp <= 0)
                {
                    Console.WriteLine("플레이어가 사망했습니다");
                    Console.WriteLine("XoX");
                    break;
                }

                Console.WriteLine("몬스터가 플레이어를 공격합니다\n");
            }
            if (isAtt)
            {
                MonsterHp -= Att; // 플레이어가 몬스터를 공격할 때마다 몬스터의 체력을 감소
                Console.WriteLine("플레이어가 몬스터를 공격합니다\n");
                if (MonsterHp <= 0)
                {
                    Console.WriteLine("몬스터가 쓰러졌습니다!!");
                    break;
                }
            }
        }
    }
}

namespace second2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몬스터가 출현했다\r");
            Console.WriteLine("(っ °Д °;)っ");

            Player NewPlayer = new Player();
            NewPlayer.Att = 2;
            NewPlayer.Damage = 1;
            NewPlayer.Df = 1; // 방어
            NewPlayer.Hp = 10;

            NewPlayer.Fight();
            Console.ReadLine();
        }
    }
}
