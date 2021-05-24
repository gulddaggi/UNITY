﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AccScreen : TETRISSCREEN
{
    TETRISSCREEN Parent;
    //부모의 생성자를 호출할 수 있다.
    public AccScreen(TETRISSCREEN _Parent) : base(_Parent.X, _Parent.Y -2, false)
    {
        Parent = _Parent;
    }



    public override void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Parent.SetBlock(y + 1, x, BlockList[y][x]);
            }
        }
    }
}
