using System;
using System.Collections.Generic;
using System.Text;

namespace ExStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //Utiliza string builder no método ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            //Alternativa ao FOREACH
            Comments.ForEach(delegate(Comment c) 
            { sb.AppendLine(c.Text); });
            return sb.ToString();
               
        }

    }
}
