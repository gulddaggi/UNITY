using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 기본 자료형 -> 이미 있다.

//
//사용자 정의자료형 중 하나
// class : 참조형 사용자 정의  struct : 값형 사용자 정의  enum : 값형 사용자 정의

//다른 언어에서는 정수형 상수라 하지만 C#에서는 아니다.
//보통 어떤 상태를 표현하는 것 중 나만의 것을 가지고 싶을 때 사용한다.
//열겨형이라 불린다.
//명찰에 가까운 값이다.
enum ITEMTYPE
{

	//내가 값의 범위를 지정한 새로운 자료형을 만들어 낼 수 있다는 장점이 있고
	//Switch와 잘 맞는다(자동완성).
	EQUIP,
	POTION,
	QUEST,
	NONESELECT
}



class Item
{
	public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;



	public void PotionTypeSetting()
	{
		ItemType = ITEMTYPE.POTION;
	}

}

namespace _22Enum
{
	class Program
	{
		static void Main(string[] args)
		{
			Item NewItem = new Item();
			NewItem.ItemType = ITEMTYPE.POTION;
			NewItem.PotionTypeSetting();
			//값형이고 int 라고 생각해도 된다. 사용방법을 제외하고는 그냥 int라고 생각하면 된다.

			Console.WriteLine(ITEMTYPE.POTION);

			ITEMTYPE Type = ITEMTYPE.POTION;

			switch (Type)
			{
				case ITEMTYPE.EQUIP:
					break;
				case ITEMTYPE.POTION:
					break;
				case ITEMTYPE.QUEST:
					break;
				case ITEMTYPE.NONESELECT:
					break;
				default:
					break;
			}

		}
		
	}
}
