public class Solution {
    public int LengthOfLastWord(string s) {
        string[] palavras = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return palavras[^1].Length;
    }
}
