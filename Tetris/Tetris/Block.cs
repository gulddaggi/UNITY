using System;

//위에서부터 블럭이 떨어지는 것을 만들고 싶다.
enum BLOCKDIR
{
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX,
}



enum BLOCKTYPE
{
    BT_I, // .
    BT_L, // .
    BT_J, // .
    BT_Z, //.
    BT_S, // .
    BT_T,// .
    BT_O, //.
    BT_MAX,
}

//4 x 4의 배열 혹은 리스트

partial class Block
{
    int X = 0;
    int Y = 0;
    string[][] Arr = null;
    //List<List<string>> BlockData = new List<List<string>>();


    BLOCKTYPE CurBlockType = BLOCKTYPE.BT_T;
    BLOCKDIR CurDirType = BLOCKDIR.BD_T;
    TETRISSCREEN Screen = null;
    AccScreen AccScreen = null;
    Random NewRandom = new Random();





    public Block(TETRISSCREEN _Screen, AccScreen _AccScreen)
    {
        if (null == _Screen || null == _AccScreen)
        {
            return;
        }


        Screen = _Screen;
        AccScreen = _AccScreen;
        DataInit();

        //인터페이스 분리원칙 : 자잘한 함수를 많이 만들고 그걸 조합해서 새기능을 만들어라.

        Reset();
    }

    public void RandomBlockType()
    {
       int RandomIndex = NewRandom.Next((int)BLOCKTYPE.BT_I, (int)BLOCKTYPE.BT_MAX);
        //int RandomIndex = (int)BLOCKTYPE.BT_S;
        CurBlockType = (BLOCKTYPE)RandomIndex;
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
    }

    public void SetAccScreen()
    {
        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if ("■" == Arr[y][x])
                {
                    AccScreen.SetBlock(Y + y - 1, X + x, Arr[y][x]);

                }
            }
        }
    }

    public void Reset()
    {
        RandomBlockType();
        X = 0;
        Y = 1;
        RandomBlockType();
        SettingBlock(CurBlockType, CurDirType); 

    }



    public bool DownCheck()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if ( "■" == Arr[y][x])
                {
                    if (AccScreen.Y == Y + y || true == AccScreen.IsBlock(Y + y, x + X, "■"))
                    {
                        SetAccScreen();
                        //쌓인다.
                        Reset();
                        return true;
                    }
                }
                
            }
        }
        //내가 더이상 내려갈 수 없는 경우
        return false;
    }

    public void Down()
    {
        //아래를 확인하고 내려갈 수 없다면 AccScreen에 쌓인다.
        //더 이상 내려갈 수 없으면  위로 올려보내고 새롭게 바뀌어야 한다.

        if (true == DownCheck())
        {
            return;
        }
        //내려간다.
        Y += 1;
    }


    private void Input()
    {
        // 키를 눌렀다 -> Console.ReadKey()가 리턴된다.

        if (false == Console.KeyAvailable)
        {
            return;
        }

       
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Down();
                break;
            case ConsoleKey.Q: //왼쪽으로 돌리기
                //enum은 --가 된다.
                --CurDirType;
                if (0 > CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_L;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.E: //오른쪽으로 돌리기
                ++CurDirType;
                if (BLOCKDIR.BD_MAX == CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_T;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            default:
                break;
        }

    }



    public void Move()
    {
        //내가 어떤 키든 눌렀을때만 

            Input();

        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }

                Screen.SetBlock(Y + y, X + x, Arr[y][x]);

            }
        }

        //Screen.SetBlock(Y, X, BlockType);
        //Screen.SetBlock(Y + 1, X, BlockType);
        //Screen.SetBlock(Y + 2, X, BlockType);
        //Screen.SetBlock(Y + 3, X, BlockType);



    }
    //protected BLOCKTYPE Type;
}


