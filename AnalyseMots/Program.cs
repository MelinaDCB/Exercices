using AnalyseMots;

Console.WriteLine("Choisissez le mot à analyser :");
string word = Console.ReadLine();
int nbVoyelle, nbConsonne;
Analyseur.CompterLettres(ref word, out nbVoyelle, out nbConsonne);
Console.WriteLine($"Le mot est donc composé de {word.Length} lettres dont {nbVoyelle} voyelles et {nbConsonne} consonnes.");
