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
    }
}
