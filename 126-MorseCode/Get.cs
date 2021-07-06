using System.Collections.Generic;
using System;

namespace _126_MorseCode
{
    
    public static class MorseCode
    {
         
         public static Dictionary<char,string> CodeDictionary = new Dictionary<char, string>{
            {'a',".-"},  {'b',"-..."},{'c',"-.-.-"},{'d',"-.."}, {'e',"."},
            {'f',"..-."},{'g',"--."}, {'h',"...."}, {'i',".."},  {'j',".---"},
            {'k',"-.-"}, {'l',".-.."},{'m',"--"},   {'n',"-."},  {'o',"---"},
            {'p',".--."},{'q',"--.-"},{'r',".-."},  {'s',"..."}, {'t',"-"},
            {'u',"..-"}, {'v',"...-"},{'w',".--"},  {'x',"-..-"},{'y',"-.--"},{'z',"--.."}
            };
        
        public static char Get (string Mcode)
        {
          char key = default;

            foreach (KeyValuePair<char, string> pair in CodeDictionary)
            {
                if (EqualityComparer<string>.Default.Equals(pair.Value, Mcode))
                {
                    key = pair.Key; 
                    break;
                }
            }
            return key;
        }

    }
}