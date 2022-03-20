using Lesson19;
using System.Collections.Generic;



Knight kt1 = new Knight();
Knight kt2 = new Knight();
HeroesTable<Knight> heroes = new HeroesTable<Knight>(3);
heroes.Set(0,kt1) ;
heroes.Set(1, kt2);
Console.WriteLine(heroes.CountKnights());
heroes.Delete(0);
Console.WriteLine(heroes.CountKnights());
Knight[] knights = heroes.knightsL();
Knight k4 = heroes[0];
