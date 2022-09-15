using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    string newContent = command[1];
                    article.Edit(newContent);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command[0] == "Rename")
                {
                    string newName = command[1];
                    article.Rename(newName);
                }
            }
            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
             Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
             Author = newAuthor;
        }
        public void Rename(string newName)
        {
            Title = newName;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
