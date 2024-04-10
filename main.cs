public class Solution {
    public string ReverseWords(string s) 
    {
        string prepend = "";
        string tmp = "";
        bool oneWord = true;
        for(int i = 0; i < s.Length; i++)
        {
            if(tmp == "" && s[i] == ' ')
            {
                // do nothing
                oneWord = false;
            }
            else if(tmp != "" && s[i] == ' ')
            {
                prepend = (prepend.Length > 0 ? tmp + " " + prepend : tmp);
                tmp = "";
                oneWord = false;
            }
            else
            {
                tmp += s[i];
                if(i == s.Length -1)
                {
                    prepend = (oneWord ? tmp : tmp + " " + prepend);
                }
            }
        }
        return prepend;    
    }
}
