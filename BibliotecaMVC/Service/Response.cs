using System.Collections.Generic;

namespace BibliotecaMVC.Service
{
    public class Response
    {
        private int resultCount {get; set;}
        private List<Result> results {get; set;} 

        public int ResultCount
        {
            get { return resultCount;}
            set { resultCount = value;}
        }

        public List<Result> Results
        {
            get { return results;}
            set { results = value;}
        }
    }

    public class Result
    {
        private string artworkUrl60{get; set;}
        private string trackName {get; set;}
        private string artistName {get; set;} 
        private string[] genres {get; set;} 
        private double price {get; set;} 
        private string description {get; set;}

        public string ArtworkUrl60
        {
            get { return artworkUrl60;}
            set { artworkUrl60 = value;}
        }
        
        public string TrackName
        {
            get { return trackName;}
            set { trackName = value;}
        }

        public string ArtistName
        {
            get { return artistName;}
            set { artistName = value;}
        }

        public string[] Genres
        {
            get { return genres;}
            set { genres = value;}
        }

        public double Price
        {
            get { return price;}
            set { price = value;}
        }

        public string Description
        {
            get { return description;}
            set { description = value;}
        }
    }
}