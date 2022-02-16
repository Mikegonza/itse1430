using System;

namespace MovieLib

{
    // class- wraps data and functionatily
    // naming nouns, pascal cased
    //default accesibility: internal for a class private for a class member 
    /// <summary> represnet a movie.</summary>summary>
    
    public class Movie
    {
        //acces modifiers
        //public- everyone
        //private-declaring type
        //internal- assembly only

        // fields where the data is stored
        //naming nouns, camel cased
        //readeable and writable (assuming accesibility)
        //work just like al other variables
        //
        public string title;
         public int duration;
         public int releaseYear = 1900;
         public string rating;
         public string genre;
         public bool isColor;
         public string description;

        private int id;
        
    }
}
