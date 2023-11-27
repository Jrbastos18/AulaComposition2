namespace Aula131Ex2.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        //Construtores
        public Comment()
        {
        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
