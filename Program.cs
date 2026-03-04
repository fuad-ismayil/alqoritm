// 1) iki ededin boyuyunu tapan alqoritim, ededler console readline den gelecek

Console.WriteLine("birinci ededi daxil edin:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ikinci ededi daxil edin:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine("daxil edilen ededlerden boyuk olan eded:" + firstNumber);
}
else if (secondNumber > firstNumber) { Console.WriteLine("daxil edilen ededlerden boyuk olan eded:" + secondNumber); }
else
{
    Console.WriteLine("ededler beraberdir");
}

// 2) verilen ededin 2e qaliqsiz bolunub bolunmediyini yoxlayan alqoritim yazaq readline ile

Console.WriteLine("2 ye qaliqsiz bolunub bolunmediyini yoxlamaq istediyiniz ededi daxil edin");
if (Convert.ToInt32(Console.ReadLine()) % 2 == 0)
{
    Console.WriteLine("daxil edilen reqem 2 ye qaliqsiz bolunur");
}
else
{
    Console.WriteLine("daxil edilen reqem 2 ye qaliqsiz bolunmur");
}

// 3) consoldan daxil edilen reqemin 100 den boyuk beraber boyukl mesaji kicikdirse kicik mesaji cixsin

if (Convert.ToInt32(Console.ReadLine()) >= 100)
{
    Console.WriteLine("boyuk");
}
else { Console.WriteLine("kicik"); }

// 4) konsoldan daxil edilen yasin 18 den boyuk adult kicikdirse child yazan alqoritm

int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Adult");
}
else { Console.WriteLine("child"); }

// 5) konsoldan daxil edilen ededin menfi mujsbet olmasinin yoxlanmasi
int importedNumber = Convert.ToInt32(Console.ReadLine());
if (importedNumber > 0)
{
    Console.WriteLine("musbet");
}
else if (importedNumber < 0)
{
    Console.WriteLine("menfi");
}
else
{
    Console.WriteLine("0 ne menfi ne musbetdir");
}

// 6) heftenin gunleri

Console.WriteLine("Import the number of the week whose name you want to learn:");
int importedWeekDay = Convert.ToInt32(Console.ReadLine());
switch (importedWeekDay)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thrusday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Wrong week day number imported");
        break;
}
;

// 7) daxil edilen ededin kubunu hesablayan alqoritm 

Console.WriteLine("kubunu oyrenmek istediyiniz ededi daxil edin:");
int numberFromUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("daxil etdiyiniz ededin kubu: " + numberFromUser * numberFromUser * numberFromUser);

// 8) aylarin gunlerini cixaran alqoritim

Console.WriteLine("Ayin gun sayini gormek ucun sira nomresini daxil et:");
int importedMonth = Convert.ToInt32(Console.ReadLine());
switch (importedMonth)
{
    case 1:
        Console.WriteLine("Yanvar: 31 gun");
        break;
    case 2:
        Console.WriteLine("Fevral: 28-29 gun");
        break;
    case 3:
        Console.WriteLine("Mart: 31 gun");
        break;
    case 4:
        Console.WriteLine("Aprel: 30 gun");
        break;
    case 5:
        Console.WriteLine("May: 31 gun");
        break;
    case 6:
        Console.WriteLine("Iyun: 30 gun");
        break;
    case 7:
        Console.WriteLine("Iyul: 31 gun");
        break;
    case 8:
        Console.WriteLine("Avqust: 31 gun");
        break;
    case 9:
        Console.WriteLine("Sentyabr: 30 gun");
        break;
    case 10:
        Console.WriteLine("Oktyabr: 31 gun");
        break;
    case 11:
        Console.WriteLine("Noyabr: 30 gun");
        break;
    case 12:
        Console.WriteLine("Dekabr: 31 gun");
        break;
    default:
        Console.WriteLine("Bele bir ay yoxdur!");
        break;
}
;

// 9) Fruits arrayi yaradib ona 7 meyve elave etmek

string[] fruitsArray = { "Apple", "Pineapple", "Banana", "Pomegranade", "Grape", "Pear", "Water melon" };

// 10) students ve 10 student adi

string[] studentsArray = { "James", "Michael", "Christopher", "Matthew", "Joshua", "Daniel", "Anthony", "William", "David", "Alexander" };

// 11) studentlerin adin cap etmek

for (int i=0;  i<studentsArray.Length; i++)
{
    Console.WriteLine(studentsArray[i]);
}

// 12) studentlerin 5 cisini

Console.WriteLine(studentsArray[4]);

// 13) seherler arrayi

string[] cities = { "Baku", "Ganja", "Sumqayit", "Mingachevir", "Lankaran", "Shaki", "Shirvan", "Nakhchivan", "Quba", "Shamakhi" };

// 14) 3e bolunen ededolerin cixsarilmasi

int[] numbers = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
for (int  i = 0;  i < numbers.Length;  i++)
{
    if (numbers[i] % 3 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}

// 15) yuxardaki arrayin ,minimumu maksimumu ve ededi ortasini tapilmasi alqoritmi

Console.WriteLine(numbers.Min());
Console.WriteLine(numbers.Max());
Console.WriteLine(numbers.Sum() / numbers.Length);