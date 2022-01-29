using System;
namespace DIO.Series
{
    public class Serie : BaseEntity
    {
        // Properties
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Destroyed { get; set; }

        // Methods
        public Serie(
            int id,
            Genre genre,
            string title,
            string description,
            int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Destroyed = false;
        }

        public override string ToString()
        {
            return $@"
                Genre: {this.Genre}
                Title: {this.Title}
                Description: {this.Description}
                Year: {this.Year}
            ";
        }

        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId()
        {
            return this.Id;
        }

        public bool returnDestroyed()
        {
            return this.Destroyed;
        }
        public void destroy()
        {
            this.Destroyed = true;
        }
    }
}
