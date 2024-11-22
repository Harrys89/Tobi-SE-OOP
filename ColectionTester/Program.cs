using MyCollections;

var MyList = new MyList<int>();

MyList.Add(1);
MyList.Add(2);
MyList.Add(3);

System.Console.WriteLine(MyList.Get(1));

var myStringList =new MyList<string>();
myStringList.Add("Generics");
myStringList.Add("sind");
myStringList.Add("toll");
myStringList.Add(":)");

for (int i = 0; i < myStringList.Count; i++)
{
    Console.WriteLine(myStringList.Get(i));
}


for (int i = 0; i < myStringList.Count; i++)
{
    Console.WriteLine(myStringList[i]);
}

System.Console.WriteLine( " array indexer setter implementier");

for(int i = 0; i < myStringList.Count; i++)
{
    myStringList[i] += ";";
    System.Console.WriteLine(myStringList[i]);
}
System.Console.WriteLine("-------Implemented-IEnumerable-------");
foreach (var x  in myStringList)
{
    Console.WriteLine(x);
}

System.Console.WriteLine("-------How does in work?-------");

var enumerator = myStringList.GetEnumerator();
while(enumerator.MoveNext())
{
    System.Console.WriteLine(enumerator.Current);
}
System.Console.WriteLine("-------Linq methods available-------");
// Enumerables are lazy-evaluated
var filteredNumbers = MyList.Where(x => x > 1);
foreach (var x  in filteredNumbers)
{
    Console.WriteLine(x);
}