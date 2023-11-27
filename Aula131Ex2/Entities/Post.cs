using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula131Ex2.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        //Quando tem relação com objetos que tem muitos, tem declarar uma lista desse objeto
        List<Comment> Comments { get; set;} = new List<Comment>();//Sempre importante instanciar a lista para não ter problemas depois.

        //Cosntrutores
        public Post() { 
        }
        //Não criar construtor com atributos para-muitos (Comments)
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //Embora o diagrama não tem o AddComments e RemoveComments, é uma boa colocar por padrão quando tem atributo para-muitos
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            //Para não ficar concatentando strings temporários que degradam a perfomance
            //Utilizamos a classe chamada StringBuilder que é responsável por fazer a montagem de uma string de uma forma super eficiente, depois de pronto, transforma em string
            StringBuilder sb = new StringBuilder();//Declarando a StringBuilder que pertence ao NameSpace System.Text
            sb.AppendLine(Title);//AppendLine adiciona o texto no fim do StringBuilder e coloca uma quebra de linha no final
            sb.Append(Likes);//Append adiciona o texto no fim do StringBuilder
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));//Declarando o Moment (DateTime) com ToString para colocar no formato desejado
            sb.AppendLine(Content);
            sb.AppendLine("Coments: ");
            foreach (Comment c in Comments) //Para cada comentário c em comentário, vai adicionar no c.Text
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();//Retorna o StringBuilder convertido para String

        }
    }
}
