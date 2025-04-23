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



/*

 //برنامه ای بنویسید که تمام  0های آرایه را به انتهای آرایه منتقل نماید.


int[] array = {45,8,0,5,5,0,0,4,777 };

Console.Write("array: ");
foreach (int i in array)
{
    Console.Write(i + " ");

}
Console.WriteLine();




int last= array.Length-1;
int a,b,c;
Console.WriteLine();


for (int i = 0; i <= last; i++)
{
    if (array[i] == 0)
    {
        array[i] = array[last];
        array[last] = 0;
        last -= 1;
    }
    
}



for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}

*/



/*
 //برنام های بنویسید که یک آرایه را در خلاف جهت عقربه های ساعت شیفت دهد.


int[] array = { 45, 8, 0, 5, 5, 0, 0, 4, 777 };

Console.Write("array: ");
foreach (int i in array)
{
    Console.Write(i + " ");

}
Console.WriteLine();


Array.Reverse(array);


Console.Write("array afoter shift: ");
foreach (int i in array)
{
    Console.Write(i + " ");

}
*/


/*
 //برنامه ای بنویسید که تمام اعداد منفی سمت چپ آرایه و اعداد مثبت سمت راست آرایه قرار گیرد.

int[] array = {45,-98,-5,45,54,32,36,5,6,54,-9,0,-6,7,-2};

Console.Write("array : ");
foreach (int i in array)
{
    Console.Write(i + " ");

}
Console.WriteLine();


Array.Sort(array);


Console.Write("array afoter sort: ");
foreach (int i in array)
{
    Console.Write(i + " ");

}
*/



/*
//برنامه ای بنویسید که نام و شماره دانشجویی و معدل دانشجویان کلاس را دریافت و لیست افرادی
//که معدل آن های بیشتر از میانگین کلاس است را چاپ نماید

Console.Write("How many students do you want to enter?");
int counter = Convert.ToInt32(Console.ReadLine());
string[,] students =new string[counter, 3];
Console.WriteLine();

string fullName, avrage, studentCode;

for (int i = 0; i < counter; i++)
{
    for (int j = 0; j < 3; j++)
    {

        Console.Write("enter fullname:");
        fullName = Console.ReadLine();
        students[i, j] = fullName;
        j++;

        Console.Write("enter studen code:");
        studentCode = Console.ReadLine();
        students[i, j] = studentCode;
        j++;

        Console.Write("enter avrage:");
        avrage = Console.ReadLine();
        students[i, j] = avrage;
        j++;
    }
    Console.WriteLine();
}


double sum = 0,avg;
for (int i = 0; i < counter; i++)
{
    sum +=Convert.ToDouble( students[i, 2]);
}

avg=sum/counter;
Console.WriteLine("total avg class{0}:",avg);


for (int i = 0; i < counter; i++)
{
    if (Convert.ToDouble(students[i,2])>avg)
    {
        Console.Write("name:{0} studentcode{1} avg:{2}", students[i,0], students[i, 1], students[i, 2]);
        Console.WriteLine();
    }
}
*/


/*

//برنامه ای بنویسید که دو لیست فاقد اعداد تکراری را دریافت و اشتراک آن ها را در لیست دیگری
//بریزد

Console.Write("count index of first array:");
int n1 = int.Parse(Console.ReadLine());
int[] array1 = new int[n1];
for (int i = 0; i < n1; i++)
{
    Console.Write("enter index {0}:",i );
    array1[i] = int.Parse(Console.ReadLine());
}

Console.Write("count index of second array: ");
int n2 = int.Parse(Console.ReadLine());
int[] array2 = new int[n2];
for (int i = 0; i < n2; i++)
{
    Console.Write("enter index {0}:", i);
    array2[i] = int.Parse(Console.ReadLine());
}

int[] intersection = new int[Math.Min(n1, n2)];
int index = 0;

for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        if (array1[i] == array2[j])
        {
            bool alreadyExists = false;
            for (int k = 0; k < index; k++)
            {
                if (intersection[k] == array1[i])
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                intersection[index] = array1[i];
                index++;
            }

            break;
        }
    }
}

Console.WriteLine("intersection:");
if (index == 0)
{
    Console.WriteLine("don't there are intersection");
}
else
{
    for (int i = 0; i < index; i++)
    {
        Console.Write(intersection[i] + " ");
    }
}

*/


