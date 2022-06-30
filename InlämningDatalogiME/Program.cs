
using InlämningDatalogiME;

var lista = new BinarySearchTree<int>();
lista.Insert(1);
lista.Insert(20);
lista.Insert(3);
lista.Insert(50);
lista.Insert(4);
lista.Insert(50);

lista.Insert(7);
lista.Insert(6);
lista.Insert(-2);
lista.Insert(-1);

lista.Print(lista.Root);
Console.WriteLine();
lista.Printe();
Console.WriteLine();
Console.WriteLine("20 exists: "+lista.Exists(20));
Console.WriteLine("21 exists: " + lista.Exists(21));
Console.WriteLine("1 exists: " + lista.Exists(1));
Console.WriteLine("-1 exists: " + lista.Exists(-1));
Console.WriteLine("-4 exists: " + lista.Exists(-4));
Console.WriteLine(lista.Count());
