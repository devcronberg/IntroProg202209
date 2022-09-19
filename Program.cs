// Variabler

// int = heltal
int tal1 = 155;
int tal2 = 200;
int resultat = tal1 + tal2;
System.Console.WriteLine(resultat);

bool sf = false;

string navn = "Michell";    // samling af tegn
System.Console.WriteLine(navn);
string navnStoreBogstaver = navn.ToUpper();
System.Console.WriteLine(navnStoreBogstaver);

// cw = Console.WriteLine

// Debugger + breakpoints

if (tal1 > 100)
{
    System.Console.WriteLine("*****");
}
else
{
    System.Console.WriteLine("######");
}

int y = 1;
if (y == 1) { } else { }

// Løkke
for (int i = 1; i < 11; i++)
{
    // Betingelse
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    System.Console.WriteLine(i + "        Test");
}


int res = LægSammen(5, 15);
System.Console.WriteLine(res);


Udskriv("mikkel");
Udskriv("mathias");


// Metode
static int LægSammen(int a, int b)
{
    return a + b;
}


static int TrækFra(int a, int b)
{
    return a - b;
}

static void Udskriv(string txt)
{
    System.Console.WriteLine("!! " + txt.ToUpper());
}
















