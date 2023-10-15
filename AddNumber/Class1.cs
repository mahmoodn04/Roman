namespace AddNumber;

public static class RomanConvertor
{
    public static string arabic(int num)
    {
        List <KeyValuePair <int, string>> roman = new List<KeyValuePair<int, string>>();  
         roman.Add(new KeyValuePair<int, string>(50, "L"));
         roman.Add(new KeyValuePair<int, string>(40, "XL"));
         roman.Add(new KeyValuePair<int, string>(10, "X"));
         roman.Add(new KeyValuePair<int, string>(9, "IX"));
         roman.Add(new KeyValuePair<int, string>(5, "V"));
         roman.Add(new KeyValuePair<int, string>(4, "IV"));
         roman.Add(new KeyValuePair<int, string>(1, "I"));
        if (num == 0) return "";

        //var value = roman.Find(x => num >= x.Key).Value;
        //var key = roman.Find(x => num >= x.Key).Key;
        
        var (key, value) = roman.Find(x => num >= x.Key);
        return value + arabic(num - key);

        
    }

}
