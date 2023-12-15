using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

List<Animal> animals = new List<Animal>()
{
new COW() { name = "ALIS", Ismale = true, weight = 400, Birthday= new DateTime(2022,10,12) },
};



foreach (Animal animal in animals)
{
    Console.WriteLine(animal);

}
//ramin karimi moghdm
//tamrine8