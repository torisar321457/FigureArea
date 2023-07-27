﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public interface IFigure
    {
        abstract bool IsValid() ;
        abstract double GetArea();
    }
}
