/*

//یکی از اساتید قصد دارد آماری از نمرات دانشجویان خود در کوییز
//های بین ترم تهیه نماید. وی  5کوییز در طول ترم برگزار کرده
//است. و اکنون به اطلاعات زیر نیاز دارد.
// میانگین نمرات هر دانشجو برای کل کوییز ها
// میانگین نمرات کل دانشجویان برای هر کوییز 


double[,] student = { {14,12,8,13,10},
                      { 15, 18, 17, 19, 12 },
                      { 1.75, 19, 19, 18, 18.5 },
                      { 16.5, 18, 17.75, 18.25, 12 } };

double sum =0,avarage,totalSum=0;


for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        sum += student[i,j];
    }


    avarage = sum/5;
    Console.WriteLine("avg the  student{1}:{0}",avarage,i+1);

    totalSum += avarage;
    avarage = 0;
    sum = 0;
}
Console.WriteLine("total avarage of students are:{0}",totalSum/4);


Console.ReadKey();
*/








/*

//دانشکده ای قصد دارد دانشجویان هر یک از رشته های تحصیلی
//خود را به تفکیک چاپ نماید. این دانشکده دارای  10رشته است که
//هر یک دارای یک کد بین  1تا  10هستند. برنامه ای بنویسد که
//مشخصات تعدادی دانشجو شامل شماره دانشجویی و کد رشته
//تحصیلی را دریافت و سپس دانشجویان هر رشته تحصیلی را به
//تفکیک چاپ نماید.


string catguryCode, studentCode;
bool berakePlane=false;

Console.Write("How many students do you want to enter?");
int counter=Convert.ToInt32(Console.ReadLine());
string[,] information = new string[counter, 2];
Console.WriteLine();


for (int i = 0; i < counter; i++)
{
    for (int j = 0; j < 2;)
    {

        Console.Write("enter your student Code:");
        studentCode = Console.ReadLine();
        if (long.TryParse(studentCode, out long number3))
        {
            berakePlane = false;

        }
        else
        {
            berakePlane = true;
            break;
        }

        Console.Write("enter your catguryCode {1:10}:");
        catguryCode = Console.ReadLine();
        if (int.TryParse(catguryCode, out int number) && Convert.ToInt32(catguryCode) <= 10)
        {
            berakePlane = false;
        }
        else {
            berakePlane = true;
            break;
        }
            
        

        Console.WriteLine();

        information[i, j] = catguryCode;
        j++;

        information[i, j] = studentCode;
        j++;



    }



    if (berakePlane) { 
        Console.WriteLine("categury Code was out of range or your input not was number");
        break;
    }
}


int[] sortByCat=new int[counter];

for (int a = 0; a < counter; a++)
{

    sortByCat[a] = Convert.ToInt32(information[a,0]);
}
Array.Sort(sortByCat);



for (int x = 0; x < counter; x++)
{
    for (int y = 0; y < counter; y++)
    {
        if (sortByCat[x] ==Convert.ToInt32(information[y, 0]))
        {
            for (int z = 0; z < 2; z++)
            {
                Console.Write(information[y, z]+" ");
            }
            Console.WriteLine();
            
        }
    }
}

*/







/*

//دانشگاهی قصد دارد دانشجویان هر یک از دانشکده های خود را به
//تفکیک رشته های آن ها چاپ نماید. این دانشگاه دارای  5دانشکده
//است که هر یک دارای  10رشته تحصیلی مختلف می باشند. هر
//یک از دانشکده ها دارای یک کد بین  1تا  5و هر رشته نیز دارای
//کدی بین  1تا  10می باشند برنامه ای بنویسید که مشخصات
//تعدادی دانشجو شامل کد دانشجویی کد دانشکده و کد رشته
//تحصیلی را دریافت و سپس دانشجویان هر رشته را از هر دانشکده
//به تفکیک چاپ نماید.




string catguryCode, studentCode, univestyCode;
bool berakePlane=false;

Console.Write("How many students do you want to enter?");
int counter=Convert.ToInt32(Console.ReadLine());
string[,] information = new string[counter, 3];
Console.WriteLine();


for (int i = 0; i < counter; i++)
{
    for (int j = 0; j < 3;)
    {

        Console.Write("enter your student Code:");
        studentCode = Console.ReadLine();
        if (long.TryParse(studentCode, out long number3))
        {
            berakePlane = false;

        }
        else
        {
            berakePlane = true;
            break;
        }

        Console.Write("enter your catguryCode {1:10}:");
        catguryCode = Console.ReadLine();
        if (int.TryParse(catguryCode, out int number) && Convert.ToInt32(catguryCode) <= 10)
        {
            berakePlane = false;
        }
        else {
            berakePlane = true;
            break;
        }
            
        
        Console.Write("enter your univestyCode {1:5}:");
        univestyCode = Console.ReadLine();
        if (int.TryParse(univestyCode, out int number2) && Convert.ToInt32(univestyCode) <= 10)
        {
            berakePlane = false;
        }
        else
        {
            berakePlane = true;
            break;
        }

        Console.WriteLine();

        information[i, j] = catguryCode;
        j++;

        information[i, j] = studentCode;
        j++;

        information[i, j] = univestyCode;
        j++;

    }



    if (berakePlane) { 
        Console.WriteLine("universty code or categury Code was out of range or your input not was number");
        break;
    }
}


int[] sortByCat=new int[counter];

for (int a = 0; a < counter; a++)
{

    sortByCat[a] = Convert.ToInt32(information[a,0]);
}
Array.Sort(sortByCat);



for (int x = 0; x < counter; x++)
{
    for (int y = 0; y < counter; y++)
    {
        if (sortByCat[x] ==Convert.ToInt32(information[y, 0]))
        {
            for (int z = 0; z < 3; z++)
            {
                Console.Write(information[y, z]+" ");
            }
            Console.WriteLine();
            
        }
    }
}

*/



/*
//برنامه ای بنویسید که مشخص کند یک عدد خاص در آرایه وجود دارد یا خیر؟ در صورت وجود
//اندیس آن را چاپ کند

int[] array = {15,210,10,546,151,0,6 };

Console.Write("enter number:");
int input =Convert.ToInt32(Console.ReadLine());

int i;
for (i = 0; i < array.Length; i++)
{
    if (array[i] == input)
    {
        Console.WriteLine(i);
        break;
    }

}
if(i == array.Length)
{
    Console.WriteLine("yor number is not in array");
}
*/



/*
 //برنامه ای بنویسید که یک عدد خاص را از یک آرایه حذف کند

int[] mainArry = { 10, 5, 87, 45, 95, 87, 15, 545, 87, 415, 0 };

Console.Write("number there are in array:");
for (int i = 0;i<mainArry.Length; i++)
{
    Console.Write(mainArry[i]+" ");
}
Console.WriteLine();



Console.Write("wich one do you want to delet?:");
int indexDel=Convert.ToInt32(Console.ReadLine());


int count = 0;

foreach (int item in mainArry)
{
    if (item != indexDel)
    {
        count++;
    }

}

int[] newArray =new int[count];
int index = 0;

foreach (int item in mainArry)
{
    if (item != indexDel)
    {
        newArray[index++] = item;
    }
}

for (int a = 0; a < newArray.Length; a++)
{
    Console.Write(newArray[a]+" ");
}
*/


/*
 //برنامه ای بنوسید که یک آرایه را در آرایه دیگر کپی کند

int[] first = { 5, 10, 415, 8789, 64565, 145, 4, 41, 4, 415645, };

int[] second = new int[first.Length];

for (int i = 0; i < first.Length; i++)
{ 
    second[i] = first[i];
}

for (int i = 0; i < first.Length; i++)
{
    Console.WriteLine(second[i]);
}
*/



/*
 //برنامه ای بنویسید که یک عدد را در مکان مورد نظر یک آرایه درج نماید


Console.Write("array:");
int[] first = { 5, 10, 415, 8789, 64565, 145, 4, 41, 4, 415645};

for (int i = 0; i < first.Length; i++)
{ 
    Console.Write(first[i]+" ");
}
Console.WriteLine();

Console.Write("inter the index you replace:");
int replace = Convert.ToInt32(Console.ReadLine());

Console.Write("inter the number you replace:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


if (replace >= 0 && replace<first.Length)
first[replace] = number;

for (int i = 0; i < first.Length; i++)
{ 
    Console.Write(first[i]+" ");
}
*/



/*
 //برنامه ای بنویسید که مقادیر تکراری یک ارایه را چاپ نماید


int[] array = { 1, 3, 5, 3, 7, 1, 9, 5 };


Console.WriteLine("repare valu:");

for (int i = 0; i < array.Length; i++)
{
    bool isDuplicate = false;

    for (int k = 0; k < i; k++)
    {
        if (array[i] == array[k])
                {
                    isDuplicate = true;
                    break;
                }
    }

    if (isDuplicate)
    continue;

    int count = 0;

   for (int j = 0; j < array.Length; j++)
   {
    if (array[i] == array[j])
    {
     count++;
    }
   }

    if (count > 1)
    {
      Console.WriteLine(array[i] + " (replay: " + count + ")");
    }
}
*/

/*

 //برنامه ای بنویسید که مقادیر تکراری دو آرایه متفاوت را چاپ نماید


int[] array1 = { 1, 321, 5, 7, 9 };
int[] array2 = { 2, 3, 4, 5, 10,321 };

Console.WriteLine("repetitive valu:");

for (int i = 0; i < array1.Length; i++)
{
    bool alreadyPrinted = false;

    for (int k = 0; k < i; k++)
    {
        if (array1[i] == array1[k])
        {
            alreadyPrinted = true;
            break;
        }
    }

    if (alreadyPrinted)
        continue;

    for (int j = 0; j < array2.Length; j++)
    {
        if (array1[i] == array2[j])
        {
            Console.WriteLine(array1[i]);
            break;
        }
    }
}

*/

/*

 //برنامه ای بنویسید که مقادیر تکراری یک آرایه را حذف نماید.


Console.Write("array:");
int[] array = { 1, 3, 5, 3, 7, 5, 9, 5 };
foreach (int i in array)
    Console.Write(i+" ");
Console.WriteLine();


int[] array2 = new int[array.Length];
int Count = 0;

for (int i = 0; i < array.Length; i++)
{
    bool isDuplicate = false;

    for (int j = 0; j < Count; j++)
    {
        if (array[i] == array2[j])
        {
            isDuplicate = true;
            break;
        }
    }

    if (!isDuplicate)
    {
        array2[Count] = array[i];
        Count++;
    }
}


Console.WriteLine("array without repetition:");
for (int i = 0; i < Count; i++)
{
    Console.Write(array2[i] + " ");
}
*/


/*
// برنامه ای بنویسید که مشخص کند دو آرایه با هم برابر هستند یا خیر؟


int[] array1 = { 1, 3, 5, 3, 7, 5, 9, 5 };
int[] array2 = { 1, 3, 5, 3, 7, 5, 9, 5, };

bool equal=false;

for (int i = 0; i < array1.Length; i++)
{

    if (array1[i] != array2[i])
    {
        equal = true;
    }
    else
    {
        equal = false;
    }

}

if (array1.Length != array2.Length)
{
    equal = true;
}


if (equal)
{
    Console.WriteLine("arras not equal");
}
else
{
    Console.WriteLine("arras is equal");
}
*/
