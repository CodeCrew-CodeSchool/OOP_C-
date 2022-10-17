


    namespace Abstraction.Classes
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is this a kid party?");
            string answer = Console.ReadLine();
            if(answer == "yes"){
        KidParty LizzysParty = new KidParty();
     // I can call my stuff here
        LizzysParty.Setup();
        LizzysParty.TearDown();
        LizzysParty.SingHappyBirthday();
        }else{
            Console.WriteLine("No other packages available at this time");
        }
        }

        // static void PartyPackage(){
        //     // Greet user. Ask them if it's a birthday!

        //     // If yes, continue down the line, if no exit :( (We don't offer other packages)

        //     // Ask if this is an adult party or a kid party 

        //     // If kid party, ask them the name of the child 

        //     // if adult party, ask them if drinks will be offered (and other services)

        //     // print out the summary of the party. and you are done!


        // }
    }
    }
