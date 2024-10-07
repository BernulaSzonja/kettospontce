using kettospontce;

List<Versenyzok> versenyzok = [];
using StreamReader sr = new(@"..\..\..\forras.txt");
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));


Console.WriteLine($"{versenyzok.Count} versenyzo fejezte be a versenyt");

var f5 = versenyzok.Count(v => v.korcsoport == "25-29");
Console.WriteLine($"{f5} versenyzo indult a 25-29-es korcsoportban");

// /surrender

//var f6 = versenyzok.Sum(v => v.kor);
//Console.WriteLine($"versenyzok atlag eletkora: {f6}");

//var fpassz = versenyzok.MinBy(v => v.uszas);
//Console.WriteLine($"legrovidebb ido: {fpassz}"); 

