using System.Xml.Schema;

namespace BlackJack
{
    public class Card
    {
        //_ instant variable 
        private string _face;
        private int _faceValue;

        public Card(string face ,int faceValue)
        {
            _face = face;
            _faceValue = faceValue;
        }
            
        public string ShowFace()
        {
            return (_face + " "+ _faceValue.ToString());
        }
        
        
        
    }
}