using System;
using System.Text.RegularExpressions;

public static class Sentence
{
    public static string WordWithMostVowels(string sentence)
    {
        var vowels = "[^aeiou]";
        var sentenceVowel = Regex.Replace(sentence, vowels, "" );
        var arraySentence = sentenceVowel.Split(" "); 
        var mostVowels =  arraySentence[0];  
        var temp = 0;
        for(var i=0; i< arraySentence.Length; i++){
            if(arraySentence[i].Length>mostVowels.Length){
                mostVowels = arraySentence[i];
                temp = i;
            }            
        }
        return sentenceVowel.Split(" ")[temp];
    }
}