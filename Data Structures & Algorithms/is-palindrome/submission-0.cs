public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLowerInvariant().Replace(" ", "");
        s = Regex.Replace(s, @"\p{P}", "");
        string reverse = "";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            reverse += s.Substring(i, 1);
        }
        if(s.Equals(reverse))
        {
            return true;
        }
        return false;
    }
}
