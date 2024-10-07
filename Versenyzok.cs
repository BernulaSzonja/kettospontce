using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kettospontce
{
    internal class Versenyzok
    {
        public string nev { get; set; }
        public string szulev { get; set; }
        public string szam { get; set; }
        public bool nem { get; set; }
        public string korcsoport { get; set; }
        public TimeSpan uszas { get; set; }
        public TimeSpan elsodep { get; set; }
        public TimeSpan kerekpar { get; set; }
        public TimeSpan masodikdep { get; set; }
        public TimeSpan futas { get; set; }
        //public int kor => (int)(DateTime.Now - szulev).Days /365;


        public Versenyzok(string sor)
        {
            var darabok = sor.Split(';');
            nev = darabok[0];
            szulev = darabok[1];
            szam = darabok[2];
            nem = darabok[3] == "n";
            korcsoport = darabok[4];
            uszas = TimeSpan.Parse(darabok[5]);
            elsodep = TimeSpan.Parse(darabok[6]);
            kerekpar = TimeSpan.Parse(darabok[7]);
            masodikdep = TimeSpan.Parse(darabok[8]);
            futas = TimeSpan.Parse(darabok[9]);

        }
        public override string ToString()
        {
            return $"Versenyző neve: {nev}" +
                $"\n\tNeme: {(nem ? "Nő" : "Férfi")}" +
                $"\n\tRajtszáma: {szam}," +
                $"\n\tSzületési éve: {szulev} " +
                $"\nIdejei: " +
                $"\n\tÚszás: {uszas} " +
                $"\n\tElső depo: {elsodep}" +
                $"\n\tKerékpár: {kerekpar}" +
                $"\n\tMásodik depo: {masodikdep}" +
                $"\n\tFutás: {futas}"; 
                //$"\n\t{kor} éves";
        }
    }
}
