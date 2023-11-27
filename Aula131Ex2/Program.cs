using Aula131Ex2.Entities;

namespace Aula131Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração do Post 1
            //Definindo os comentários
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm goin to visit this wonderful country!",
                12); //Declarado o os atributos moment, title, content e likes, respectivamente

            //Adicionando os comentários
            p1.AddComment(c1);
            p1.AddComment(c2);

            //Declaração do Post 2
            //Definindo os comentários
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5); //Declarado o os atributos moment, title, content e likes, respectivamente

            //Adicionando os comentários
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}