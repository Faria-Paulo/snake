﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Food
    {
        public Point Location { get; private set; }//Point já é um **** que representa um ponto com X e Y.

        public void CreateFood(){
            Random rnd = new Random();
            Location = new Point(rnd.Next(0,27), rnd.Next(0,27));//Criando um ponto aleatório para gerar a comidinha.
        }
    }
}