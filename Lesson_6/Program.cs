//Задача увеличить каждую из координат в 2 раза
using System.Linq;

string text = "(1,2) (2,3) (4,5) (9,7)"
            .Replace("(", "") //позволяет указать какие элементы в строке нужно не учитывать и на что их заменить
            .Replace(")", "")
            ;
Console.WriteLine(text);

var data = text.Split(" ") //позволяет разбить данные на массив - например первое число будут х, а второе у
            .Select(item => item.Split(','))
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
            .Where(e => e.x % 2 == 0)
            .Select(point => (point.x * 10, point.y))
            .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    //Console.WriteLine();
}
