    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        int hour = Convert.ToInt16(s[0] + "" + s[1]);
        string ans;

        if (s[s.Length - 2].ToString() == "P")
        {
            ans = (hour == 12) ? hour.ToString() : (hour + 12).ToString();
        }
        else
        {
            ans = (hour == 12) ? "00" : "0"+hour.ToString();        
        }

        return ans + s.Substring(2,6);
    }
