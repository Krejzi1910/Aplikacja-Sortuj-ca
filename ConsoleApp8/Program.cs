using System;

public class AplikacjaSortująca
{
    // Stała określająca długość tablicy
    private const int DługoscTablicy = 10;

    /**************************************
    * Nazwa funkcji:        Main
    * Parametry wejściowe:  args - tablica stringów, przechowuje argumenty przekazane do programu
    * Wartość zwracana:     void - funkcja nie zwraca żadnej wartości
    * Autor:                Aleksander Gędek 3D
    **************************************/
    public static void Main(string[] args)
    {
        int[] liczby = new int[DługoscTablicy];
        Console.WriteLine("Wprowadź liczby:");

        // Wprowadzanie liczb do tablicy
        for (int i = 0; i < DługoscTablicy; i++)
        {
            liczby[i] = int.Parse(Console.ReadLine());
        }

        // Wywołanie funkcji sortującej malejąco
        SortujMalejaca(liczby);

        Console.WriteLine("Posortowane liczby:");
        for (int i = 0; i < DługoscTablicy; i++)
        {
            Console.WriteLine(liczby[i]);
        }
    }

    /**************************************
    * Nazwa funkcji:        SortujMalejaca
    * Parametry wejściowe:  liczby - tablica liczb całkowitych do posortowania
    * Wartość zwracana:     void - funkcja nie zwraca żadnej wartości
    * Autor:                Aleksander Gędek 3D
    **************************************/
    private static void SortujMalejaca(int[] liczby)
    {
        for (int i = 0; i < DługoscTablicy - 1; i++)
        {
            int indeksMax = i;
            for (int j = i + 1; j < DługoscTablicy; j++)
            {
                if (liczby[j] > liczby[indeksMax])
                {
                    indeksMax = j;
                }
            }

            if (indeksMax != i)
            {
                ZamieńElementy(liczby, i, indeksMax);
            }
        }
    }

    /**************************************
    * Nazwa funkcji:        ZamieńElementy
    * Parametry wejściowe:  liczby - tablica liczb całkowitych, i - indeks pierwszego elementu, j - indeks drugiego elementu
    * Wartość zwracana:     void - funkcja nie zwraca żadnej wartości
    * Autor:                Aleksander Gędek 3D
    **************************************/
    private static void ZamieńElementy(int[] liczby, int i, int j)
    {
        int temp = liczby[i];
        liczby[i] = liczby[j];
        liczby[j] = temp;
    }
}
