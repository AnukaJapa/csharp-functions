// See https://aka.ms/new-console-template for more information

//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina


//BONUS:
//Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.

//A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia
//inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.


void StampaArrayInteri(int[]array)
{
    string risultato = "";
  for(int i =0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            risultato += $" {array[i]} ";
        } else
        {
            risultato += $" {array[i]}, ";
        }
    }

    Console.WriteLine($" [ {risultato} ] ");
};

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato (int numero)
{
    return numero*numero;
};


//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un
//nuovo array con tutti gli elementi elevati quadrato.

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = (int[])array.Clone();
    for(int i=0; i< newArray.Length; i++)
    {
        newArray[i] = Quadrato(newArray[i]);
    }
    return newArray;
}




//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma
//totale di tutti gli elementi dell’array.

int sommaElementiArray(int[] array)
{
    int somma = 0;
    foreach(int number in array)
    {
        somma += number;
    }
    return somma;
};


//Una volta completate queste funzioni di utilità di base, e dato il seguente
//array di numeri [2, 6, 7,5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video

int[] numbersArray = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(numbersArray);



//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
int[] numbersArrayAlQuadrato = ElevaArrayAlQuadrato(numbersArray);

Console.WriteLine("Array elevato al quadrato : ");
StampaArrayInteri(numbersArrayAlQuadrato);


Console.WriteLine("e qua sarà originale");
StampaArrayInteri(numbersArray);


//Stampare la somma di tutti i numeri
Console.WriteLine("SOMMA dei numeri dell'array originale : ");

Console.WriteLine(sommaElementiArray(numbersArray));


//Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine("SOMMA dei numeri dell'array al quadrato : ");

Console.WriteLine(sommaElementiArray(numbersArrayAlQuadrato));











