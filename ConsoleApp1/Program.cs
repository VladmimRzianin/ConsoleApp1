// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string name = "Vladimir";
//int age = 18;
//bool study = true;
//double score = 4.5;
//Console.WriteLine($"имя: {name}");
//Console.WriteLine($"Возраст: {age}");
//Console.WriteLine($"учится: {study}");
//Console.WriteLine($"Ср. балл: {score}");

//Console.WriteLine("Введите x и y");
//int x = Convert.ToInt32(Console.ReadLine());
//int y = Convert.ToInt32(Console.ReadLine());
//x = x + y;
//Console.WriteLine(x);
//Console.ReadKey();

//var c = null;
//Console.WriteLine("hello, World!");

//Console.WriteLine("goodbye, World...");

//Console.WriteLine("welcome in C#");

//double number = 5.2;
//Console.WriteLine($"Число с плав точкой {number}");

//bool day = true;
//Console.WriteLine($"день {day}");

//object a = 14;
//object b = 6.2;
//object c = "hi";
//Console.WriteLine($"челое число {a}");
//Console.WriteLine($"число с точкой {b}");
//Console.WriteLine($"приветствие {c}");

//int numb = 35;
//Console.WriteLine($"цифра {numb}");

//Console.WriteLine("ввести две переменные");
//int numbers = Convert.ToInt32(numbers);
//int number1 = 6;
//int number2 = 8;

//if (number1 > number2)
//{
//    Console.WriteLine($"Число {number1} больше {number2}");
//}
//else if (number1 < number2)
//{
//    Console.WriteLine($"Число {number1} меньше {number2}");
//}
//else
//{
//    Console.WriteLine($"Числа равны");
//}

//using System.Collections;

//int name = 2;

//int DoOperation(int a1, int a2, int b)
//{
//    switch (b)
//    {
//        case 1: return a1 + a2;
//        case 2: return a1 - a2;
//        case 3: return a1 * a2;
//        default: return 0;
//    }
//}

//int a = int.Parse("10");
//double a2 = int.Parse("10.3");

//Console.WriteLine("введите строку");
//string? input = Console.ReadLine();

//bool result = int.TryParse(input, out var value);

//if (result)
//{
//    Console.WriteLine("запарсил");
//}
//else
//{
//    Console.WriteLine("не вышло");
//}



//start:

//string simb;

//Console.WriteLine("ввести первое число");
//double x = Convert.ToDouble(Console.ReadLine());


//Console.WriteLine("ввести действие");
//simb = Convert.ToString(Console.ReadLine());

//Console.WriteLine("ввести второе число");
//double y = Convert.ToDouble(Console.ReadLine());

//switch (simb)
//{
//	case "+":
//		Console.WriteLine(x + y);
//		goto start;
//	case "-":
//		Console.WriteLine(x - y);
//		goto start;
//	case "*":
//			Console.WriteLine(x * y);
//		goto start;
//	case "/":
//			Console.WriteLine(x / y);
//		goto start;
//	default:
//		Console.WriteLine("Вы не ввели действие");
//		goto start;
//}

//int x = 3;
//int y = 2;

//int z = x < y ? (x + y) : (y - x);
//Console.WriteLine(z);

//try /*gпытка проверить ошибку*/
//{
//    int x = 5;
//    int y = x / 0;
//    Console.WriteLine($"{y}");
//}
//catch /*поимка ошибка и ее отображение*/
//{
//    Console.WriteLine("поймано исключение");
//}
//finally /*ошибок нет, весь остальной код*/
//{

//}


//try
//{

//      int x = 5;
//      int y = x / 0;
//      Console.WriteLine($"{y}");
//}
//catch (Exception ex)
//{
//    string message = ex.Message;
//    Console.WriteLine( message );
//}

//int x = 1;
//int y = 0;

//try
//{
//    int result = x / y;
//    int result2 = y / x;
//}
//catch (DivideByZeroException) when (y == 0)
//{
//    Console.WriteLine("Y должен быть не равен 0");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


using ConsoleApp1;

start:


Practicheskaya2 pract2 = new Practicheskaya2();

string simb;

Console.WriteLine("ввести первое число");
double x = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("ввести действие");
simb = Convert.ToString(Console.ReadLine());

Console.WriteLine("ввести второе число");
double y = Convert.ToDouble(Console.ReadLine());



switch (simb)
{
	case "+":
		pract2.plus(x, y);
		goto start;
	case "-":
		pract2.minus(x, y);
		goto start;
	case "*":
			pract2.umnoshenie(x, y);
		goto start;
	case "/":
			pract2.delenie(x, y);
		goto start;
	case "степень":
		pract2.stepen(x, y);
		goto start;
	case "sqrt":
		pract2.sqrt(x, y);
		goto start;
	case "округление":
		pract2.okryglenie(x, y);
		goto start;
	case "арксинус":
		pract2.arksin(x, y);
		goto start;
	case "площадь прямоугольника":
		pract2.ploshadpr(x, y);
		goto start;
	case "тангенс":
		pract2.tan(x, y);
		goto start;
	case "гиперболический тангенс":
		pract2.tanh(x, y);
		goto start;
	case "периметр прямоугольника":
		pract2.perimetr(x, y);
		goto start;
	case "площадь куба":
		pract2.plcube(x);
		goto start;
	default:
        Console.WriteLine("Вы не ввели действие");
        Console.WriteLine("ошибка");
		break;
}