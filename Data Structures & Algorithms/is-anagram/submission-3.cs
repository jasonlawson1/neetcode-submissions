public class Solution {
    public bool IsAnagram(string s, string t){

        Dictionary<char, int> anagram = new Dictionary<char, int>();
        Dictionary<char, int> anagram2 = new Dictionary<char, int>();
        

        if(s.Length != t.Length){
            return false;
        }

        for(int i = 0; i < s.Length; i++){
            if(!anagram.TryAdd(s[i], 0)){
                anagram[s[i]] += 1;
            }else{
                anagram.TryAdd(s[i], 0);
            }
            if(!anagram2.TryAdd(t[i], 0)){
                anagram2[t[i]] += 1;
            }else{
                anagram2.TryAdd(t[i], 0);
            }
            
        }
        for(int i = 0; i < s.Length; i++){
            if(!(anagram.TryGetValue(s[i], out int value ) && anagram2.TryGetValue(s[i], out int value2) && value == value2)){
                return false;
            }
        }
        return true;
    }
}
