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
        /// 
         public string Tittle
        {
            get {return _title ; }
            set { _title = value; }
        }


         private string _title;
         public int _duration;
         public int _releaseYear = 1900;
         public string _rating;
         public string _genre;
         public bool _isClassic;
         public string _description;


        public bool IsBlackAndWhite
        {
            get { return _isBlackAndWhite; }
            set { }
        }

        private bool _isBlackAndWhite;
        // all instace methods have a hidden this parameter that represents the instance
        ///<summary>Validates the instance.</summary>
        /// <returns>Return error message if any or empty string otherwise. </returns>

        public void CalculateBlackAndWhite()
        {
            isBlackAndWhite= releaseYear <= 1939;

        }

        public string Validate(/* movie this*/)
        {
            var tittle="";

            if (String.IsNullOrEmpty(_tittle))
                return "tittle is required";
            if (_duration<0)
                return "duration must be a least 0";
            if (_releaseYear < 1900)
                return "Release must be a 1900";
            if (String.IsNullOrEmpty(_genre) )
                return "Genre is required";
            //special rule - no classoic movie before 1940
            if (_isClassic $$ _releaseyear < 1940)
                return " release year must be at least 1940 to be a classic";

            return"";

        }

        private int id;
        
    }
}
