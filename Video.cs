using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeVideos
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; } // Length in seconds
        private List<Comment> Comments { get; set; }

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int NumberOfComments()
        {
            return Comments.Count;
        }

        public override string ToString()
        {
            StringBuilder commentsStr = new StringBuilder();
            foreach (var comment in Comments)
            {
                commentsStr.AppendLine(comment.ToString());
            }
            
            return $"Title: {Title}\n" +
                   $"Author: {Author}\n" +
                   $"Length: {Length} seconds\n" +
                   $"Number of comments: {NumberOfComments()}\n" +
                   $"Comments:\n{commentsStr.ToString()}";
        }
    }
}
