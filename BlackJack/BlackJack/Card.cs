using System;
using System.Xml.Schema;

namespace BlackJack
{
    public class Card
    {
        //_ instant variable 
        private string _name; 
        private string _suite;
        private int _value;

        public Card( string name, string suite, int value )
        {
            _suite = suite;
            _value = value;
            _name = name;

        }

        public int UpdateValueTo11()
        {
            return  _value = 11;
        }
            
        public string RevealFace()
        {
            return (_suite + " "+ _name.ToString());
        }

        public int RevealFaceValue()
        {
            return _value;
        }
        
      
        
        
        
    }
}