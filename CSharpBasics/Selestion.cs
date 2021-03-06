using System;
using System.IO;
using System.Linq;
using LearnCOllection;

class SelectionStatement{
static void Main(){
   var countriesText = File.ReadAllText("Countries.txt");
           String [] countries = countriesText.Split("\r\n");
         var countriesWithInitial = countries.Where(x => x.StartsWith("N")).Select(x => x);
         foreach(var country in countriesWithInitial){
             Console.WriteLine(country);
         }

      FileIO fileIO = new FileIO();
    fileIO.FileHandling();
    fileIO.LearnFileInfo();
    fileIO.LearnDirectories();
    SelectionStatement ss = new SelectionStatement();
    ItterationStatement itteration = new ItterationStatement();
    itteration.LearnLoop();
    ss.LearnIfelse();
    ss.LearnSwitch();
    itteration.LearnWhile();
    Collection collection = new Collection();
    collection.LearnDictionary();
   

}
void LearnIfelse(){
    Console.Write("Enter any number");
    String input = Console.ReadLine();
    
    byte x = byte.Parse(input);
    if(x==34){

        Console.WriteLine("I am student");

        }
        else 
        {
            Console.WriteLine("I am in else");
        }

    }
    void LearnSwitch(){
        char option = 'y';
        switch(option){
            case 'n':
            Console.WriteLine("you opted for no");
            break;
            case 'm':
             Console.WriteLine("you opted for no");
            break;
            case 'o':
             Console.WriteLine("you opted for no");
            break;
            case 'y':
             Console.WriteLine("you opted for Yes");
            break;
            default:
            break;


        }
    }
}