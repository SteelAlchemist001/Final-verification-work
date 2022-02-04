//"Контрольная работа"
void PrintArray(string[] newarray)
{
    Console.Write("[");
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write($"{newarray[i]}, ");
    }
    Console.WriteLine("]");
}

int newarraysize(string[] newarray)
{
    int targetarraylength = 0;
    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i].Length <= 3)
        {
            targetarraylength++;
        }
    }
    return targetarraylength;
}

void Fills3array(string[] newarray, string[] targetarray)
{
    for (int j = 0, k = 0; j < newarray.Length; j++)
    {
        if (newarray[j].Length <= 3)
        {
            targetarray[k] = newarray[j];
            k++;
        }
    }
}

void Demo ()
{
string[] countries = {"Russia", "USA", "J", "CDN", "Germany", "France", "Italy"};
    Console.WriteLine(" ");
    string[] countriesshort = new string [newarraysize(countries)];
    Fills3array (countries, countriesshort);
    
    PrintArray(countriesshort);
    
}

Demo ();