﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
   public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);

        }
    }
}
