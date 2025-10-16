


#region Tek&Cut
//int CountTek(int num)
//{
//    int count = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    return count;
//}

//int CountCut(int num)
//{
//    int count = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }

//    }
//    return count;
//}

//Console.WriteLine(CountCut(1000));
#endregion

#region Palindrom
//bool isPalindrom(string word)
//{
//    string reversed = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        reversed += word[i];
//    }
//    if (reversed.ToLower() == word.ToLower())
//    {
//        return true;
//    }
//    return false;

//}



//Console.WriteLine(isPalindrom("Amma"));
#endregion

#region Ardicilliq
//void Ardcilliq(int a,int b,int c)
//{
//    if (a<=b && b<=c)
//    {
//        Console.WriteLine("Ardcilliq dogrudur");
//        Console.WriteLine("returundan asagdaki kod setri");

//    }
//    else
//    {
//        Console.WriteLine("Ardcilliq pozulub");

//    }
//}
//Ardcilliq(2,5,7);

#endregion

#region MAssiv


//float Array(params int[] array) {

//    int sum=0;
//    foreach(int i in array) {
//        sum+=i; 

//    }
//    return sum/array.Length;
//}
//int[] arrays = { 1,2,4,2,1     };


//Console.WriteLine(Array(313,31,3,1,4114,31,1));




#endregion

#region

//Console.WriteLine("Ilk ededi daxil edin ");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Ikinci  ededi daxil edin ");
//int b = int.Parse(Console.ReadLine());


//Console.WriteLine("Simvol daxil edin ");
//string simvol = Console.ReadLine();
//switch (simvol)
//{
//    case "toplama":
//        Console.WriteLine(a+b);
//        break;
//    case "cixma":
//        Console.WriteLine(a - b);
//        break;
//    case "bolme":
//        if (b==0)
//        {
//        Console.WriteLine("0-a bolme yoxdur");
//            break;
//        }
//        Console.WriteLine(a / b);
//        break;
//    case "vurma":
//        Console.WriteLine(a * b);
//        break;
//        default:
//        Console.WriteLine("Duzgun simvol daxil edin");
//        break;
//}


#endregion

#region Regemlerin cemi
//int SumDigit(int num)
//{
//    int sum = 0;
//    while (num > 0)
//    {
//        int digit = num % 10;
//        sum += digit;
//        num /= 10;
//    }
//    return sum;

//}



//int num1 = SumDigit(435);
//int num2 = SumDigit(12331);

//if (num1>num2)
//{
//    Console.WriteLine("");
//}
//else
//{
//    Console.WriteLine("diger hal");
//}



//    Console.WriteLine(SumDigit(143));
#endregion

#region Basglanic ve son  
//int EvenSum(int start, int end)
//{

//    int sum = 0;
//    for (int t = start; t < end; t++)
//    {
//        if (t % 2 == 0)
//        {
//            sum += t;
//        }
//    }
//    return sum;
//}


//Console.WriteLine(EvenSum(1, 5));



#endregion

#region Ucbucaq 


//void Ucbucaq(int a,int b,int c)
//{
//    if (a==b && b==c)
//    {
//        Console.WriteLine("Berabertereflidir");
//    }
//    else if (a==c || a==b || c==b)
//    {

//        Console.WriteLine("beraberyanlidir");

//    }
//    else { Console.WriteLine("Muxteliftereflidir"); }
//}



#endregion

#region  Qisa Factorial


//int Factorial(int num)
//{
//    if(num==0 || num == 1)
//    {
//        return 1;
//    }
//    return num * Factorial(num-1);
//}

#endregion

#region MaxEle
//int[] numbers = { 21, 414, 21, 31, 14 };
//int max = numbers[0];
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i]>max)
//    {
//        max = numbers[i];
//    }

//}
//Console.WriteLine(max);
#endregion

#region Ternary Operator


//int a = 6;
//int b = 7;

//bool IsSUm(int a,int b)
//{
//    if (a>b)
//        return true;
//        return false;
//        return a > b ? true : false;

//}



#endregion

#region ArraySort


//int[] arr = { 1, 4, 2, 6, 3, 8, 5 };

//for(int i = 0; i < arr.Length;i++)
//{
//    int minIndex = i;
//    for(int j = i + 1; j < arr.Length; j++)
//    {
//      if (arr[j]<arr[minIndex]){
//                minIndex = j;
//        }
//    }
//    if (minIndex != i)
//    {
//        int temp = arr[i];
//        arr[i] = arr[minIndex];
//        arr[minIndex] = temp;
//    }

//}

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}


#endregion



#region Tek&Cut
//int CountTek(int num)
//{
//    int count = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    return count;
//}

//int CountCut(int num)
//{
//    int count = 0;
//    for (int i = 1; i <= num; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }

//    }
//    return count;
//}

//Console.WriteLine(CountCut(1000));
#endregion

#region Palindrom
//bool isPalindrom(string word)
//{
//    string reversed = "";
//    for (int i = word.Length - 1; i >= 0; i--)
//    {
//        reversed += word[i];
//    }
//    if (reversed.ToLower() == word.ToLower())
//    {
//        return true;
//    }
//    return false;

//}



//Console.WriteLine(isPalindrom("Amma"));
#endregion

#region Ardicilliq
//void Ardcilliq(int a,int b,int c)
//{
//    if (a<=b && b<=c)
//    {
//        Console.WriteLine("Ardcilliq dogrudur");
//        Console.WriteLine("returundan asagdaki kod setri");

//    }
//    else
//    {
//        Console.WriteLine("Ardcilliq pozulub");

//    }
//}
//Ardcilliq(2,5,7);

#endregion

#region MAssiv


//float Array(params int[] array) {

//    int sum=0;
//    foreach(int i in array) {
//        sum+=i; 

//    }
//    return sum/array.Length;
//}
//int[] arrays = { 1,2,4,2,1     };


//Console.WriteLine(Array(313,31,3,1,4114,31,1));




#endregion

#region

//Console.WriteLine("Ilk ededi daxil edin ");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Ikinci  ededi daxil edin ");
//int b = int.Parse(Console.ReadLine());


//Console.WriteLine("Simvol daxil edin ");
//string simvol = Console.ReadLine();
//switch (simvol)
//{
//    case "toplama":
//        Console.WriteLine(a+b);
//        break;
//    case "cixma":
//        Console.WriteLine(a - b);
//        break;
//    case "bolme":
//        if (b==0)
//        {
//        Console.WriteLine("0-a bolme yoxdur");
//            break;
//        }
//        Console.WriteLine(a / b);
//        break;
//    case "vurma":
//        Console.WriteLine(a * b);
//        break;
//        default:
//        Console.WriteLine("Duzgun simvol daxil edin");
//        break;
//}


#endregion

#region Regemlerin cemi
//int SumDigit(int num)
//{
//    int sum = 0;
//    while (num > 0)
//    {
//        int digit = num % 10;
//        sum += digit;
//        num /= 10;
//    }
//    return sum;

//}



//int num1 = SumDigit(435);
//int num2 = SumDigit(12331);

//if (num1>num2)
//{
//    Console.WriteLine("");
//}
//else
//{
//    Console.WriteLine("diger hal");
//}



//    Console.WriteLine(SumDigit(143));
#endregion

#region Basglanic ve son  
//int EvenSum(int start, int end)
//{

//    int sum = 0;
//    for (int t = start; t < end; t++)
//    {
//        if (t % 2 == 0)
//        {
//            sum += t;
//        }
//    }
//    return sum;
//}


//Console.WriteLine(EvenSum(1, 5));



#endregion

#region Ucbucaq 


//void Ucbucaq(int a,int b,int c)
//{
//    if (a==b && b==c)
//    {
//        Console.WriteLine("Berabertereflidir");
//    }
//    else if (a==c || a==b || c==b)
//    {

//        Console.WriteLine("beraberyanlidir");

//    }
//    else { Console.WriteLine("Muxteliftereflidir"); }
//}



#endregion

#region  Qisa Factorial


//int Factorial(int num)
//{
//    if(num==0 || num == 1)
//    {
//        return 1;
//    }
//    return num * Factorial(num-1);
//}

#endregion

#region MaxEle
//int[] numbers = { 21, 414, 21, 31, 14 };
//int max = numbers[0];
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i]>max)
//    {
//        max = numbers[i];
//    }

//}
//Console.WriteLine(max);
#endregion

#region Ternary Operator


//int a = 6;
//int b = 7;

//bool IsSUm(int a,int b)
//{
//    if (a>b)
//        return true;
//        return false;
//        return a > b ? true : false;

//}



#endregion

#region ArraySort

//int[] arr = { 1, 4, 2, 6, 3, 8, 5 };

//for(int i = 0; i < arr.Length;i++)
//{
//    int minIndex = i;
//    for(int j = i + 1; j < arr.Length; j++)
//    {
//      if (arr[j]<arr[minIndex]){
//                minIndex = j;
//        }
//    }
//    if (minIndex != i)
//    {
//        int temp = arr[i];
//        arr[i] = arr[minIndex];
//        arr[minIndex] = temp;
//    }

//}

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

#endregion



//int temp = 0;   



//string  IsNese(int temp)
//{
//    return temp < 0 ? "soyuqdur"
//    : ((temp < 30) ? "normaldir" : "istidir");

//} 



//int Regem(int num)
//{
//    int min = num % 10;

//    while (num > 0)
//    {
//        int reqem=num % 10;
//        if (reqem<min)
//        {
//            min = reqem;
//        }
//        num /= 10;  
//    }
//    return min; 
//}
//Console.WriteLine(Regem(-1331));



#region Array&ArrayMetods

////int[,] ints = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int[] arr2= (int[])arr.Clone();
//arr[2] = 999;

//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}
#endregion


#region Random

//Random random = new Random();
// int secret=  random.Next(1, 16);

//int attempt = 5;


//while (attempt > 0)
//{
//    Console.WriteLine("Ededinizi daxil edin");
//    int num = int.Parse(Console.ReadLine());
//    if (num==secret)
//    {
//        Console.WriteLine($"Ugurlu alindi: {num}");
//        break;  
//    }
//    else
//    {
//        if (attempt == 1)
//        {
//            Console.WriteLine("Cehd sayiniz bitdi");
//        }
//        else
//        {

//            Console.WriteLine("yeniden yazin");
//        }
//        attempt--;

//    }
//}




#endregion

#region Palindrom 

//int [] arr = { 1, 2, 1, 21, 2, 3, 2, 1 }; 

//bool IsPalindrom(int[] arr)
//{
//    for (int i = 0; i < arr.Length / 2; i++)
//    {
//        if (arr[i] != arr[arr.Length - 1 - i])
//        {
//            return false;
//        }
//    }
//    return true;
//}
//Console.WriteLine(IsPalindrom(arr));



#endregion
#region Resize
//void Resize(ref int[] array, int size)
//{
//    int[] newArray = new int[size];

//    if (array != null)
//    {
//        if (array.Length < newArray.Length)
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                newArray[i] = array[i];
//            }
//        }
//        else if (array.Length > newArray.Length)
//        {
//            for (int i = 0; i < newArray.Length; i++)
//            {
//                newArray[i] = array[i];
//            }
//        }
//    }
//    array = newArray;
//}
//int[] arr = { 1, 2, 3, 4, 5 };
//Resize(ref arr, 28);
//Console.WriteLine(string.Join(", ", arr));
#endregion


#region ClassvsObject




using TestApp.Models;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("Emin","Imanverdiyev",22);

        }
    }



    




}

#endregion











