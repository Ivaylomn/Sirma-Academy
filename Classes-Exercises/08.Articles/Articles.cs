namespace _08.Articles
{
    internal class Articles
    {
        private string title;
        private string content;
        private string author;

        public Articles(string title, string content, string author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
        }

        public void Edit(string newContent)
        {
            content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            title = newTitle;
        }

        public override string ToString()
        {
            return $"{title} - {content}: {author}";
        }
    }
}
