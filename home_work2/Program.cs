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
