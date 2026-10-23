public class Solution {
    public bool IsAnagram(string s, string t){

        int count = 0;
        Dictionary<char, int> anagram = new Dictionary<char, int>();

        if(s.Length != t.Length){
            return false;
        }

        for(int i = 0; i < s.Length; i++){
            if(anagram.ContainsKey(s[i])){
                anagram[s[i]]++;
            }else{
                anagram[s[i]] = 1;
            }

            if(anagram.ContainsKey(t[i])){
                anagram[t[i]]--;
            }else{
                anagram[t[i]] = -1;
            }
            
        }
        foreach(int value in anagram.Values){
            if(value != 0){
                return false;
            }
        }
        return true;
    }
}
