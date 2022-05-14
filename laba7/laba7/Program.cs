using laba7;

char[] charArray = new char[] { 'a', 'b', 'c', 'd', 'e' };
char[] charArray2 = new char[] { 'a', 'b', 'h', 'i', 'j' };
char[] charArray3 = new char[] { 'a', 'b', 'c', 'd', 'e' };

SetOfChar obj1 = new(charArray), obj2 = new(charArray2), obj3 = new(charArray3);

obj1.Print();
obj2.Print();

SetOfChar obj4 = obj1 + obj2;

obj4.Print();

SetOfChar obj5 = obj1 - obj2;
obj5.Print();

SetOfChar obj6 = obj1 * obj2;
obj6.Print();

Console.WriteLine(obj1 == obj2);
Console.WriteLine(obj1 == obj3);
Console.WriteLine(obj1 != obj2);
Console.WriteLine(obj1 != obj3);

Console.WriteLine(obj1.ToString());

Console.WriteLine(obj1[1]);

string str = obj1;

Console.WriteLine(str);

SetOfChar obj7 = (SetOfChar)str;
Console.WriteLine(obj7);