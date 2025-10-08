


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



dynamic name= "Hello, World!";
name = 234;




Console.WriteLine(name);

