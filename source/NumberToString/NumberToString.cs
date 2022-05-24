namespace NumberToString;
public class NumberToString
{
    public string Convert(int number){
        if(number == 0) return "Zero";
        if(number == 1) return "One";
        if(number == 2) return "Two";
        if(number == 3) return "Three";
        if(number == 4) return "Four";
        if(number == 5) return "Five";
        return string.Empty;
    }
}
