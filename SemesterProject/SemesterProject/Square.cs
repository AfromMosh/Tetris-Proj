﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProject
{
    class Square : Shape
    {        
        char[,] theBlock = new char[,] { { '#', '#' }, { '#', '#' } };
        
        public override char[,] TheBlock
        {
            get
            {
                return theBlock;
            }
        }

        public override int BottomPointColumn { get; set; }
    }
}
