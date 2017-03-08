namespace BlackJackGame
{
    public class Card{
        public string stringVal{get;set;}
        public string suit{ get; set; }
        public int value { get; set; }   
        public Card(string suitType,int val,string strVal){
            suit=suitType;
            value=val;
            stringVal=strVal;
        }     
    }

}
