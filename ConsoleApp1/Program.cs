using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    private static Dictionary<char, string> morseDict; //polje morseDict(deklaracija)
    private static object key;

    static void Main()
    {
        DictionaryInitialize();

        Console.WriteLine("Prosim izberite program, ki ga zelite zagnati.");
        Console.WriteLine("1. prevedite MORSE CODE v abecedo");
        Console.WriteLine("2. prevedite ABECEDO v morse code");
        string izbira_programa = Console.ReadLine();
        switch (izbira_programa)
        {
            case "1":

                Console.WriteLine("Vnesite znake, ki jih zelite prevesti v Morsejevo abecedo.");
                string alphabetInput = Console.ReadLine();
                Console.WriteLine("Prevod: " + Prevedi_v_morse(alphabetInput));
                Console.ReadKey();
                break;

            case "2":

                Console.WriteLine("Vnesite znake v abecedi, ki jih zelite prevesti v Morsejevo abecedo.");
                string morseInput = Console.ReadLine();
                Console.WriteLine("Prevod: " + Prevedi_v_abecedo(morseInput));
                Console.ReadKey();
                break;
        }
    }

    private static void DictionaryInitialize()  //initializacija slovarja 
    {
        morseDict = new Dictionary<char, string>()
                                   {
                                       {'A', ".-"},
                                       {'B', "-..."},
                                       {'C', "-.-."},
                                       {'D', "-.."},
                                       {'E', "."},
                                       {'F', "..-."},
                                       {'G', "--."},
                                       {'H', "...."},
                                       {'I', ".."},
                                       {'J', ".---"},
                                       {'K', "-.-"},
                                       {'L', ".-.."},
                                       {'M', "--"},
                                       {'N', "-."},
                                       {'O', "---"},
                                       {'P', ".--."},
                                       {'Q', "--.-"},
                                       {'R', ".-."},
                                       {'S', "..."},
                                       {'T', "-"},
                                       {'U', "..-"},
                                       {'V', "...-"},
                                       {'W', ".--"},
                                       {'X', "-..-"},
                                       {'Y', "-.--"},
                                       {'Z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."},
                                       {'.', ".-.-.-"},
                                       {',', "--..--"},
                                       {'?', "..--.."},
                                       {':', "---..."}
                                   };


    }


    private static string Prevedi_v_morse(string vnos)
    {
        StringBuilder preveden_string = new StringBuilder();

        foreach (char crka in vnos)
        {
            if (morseDict.ContainsKey(crka))
            {
                preveden_string.Append(morseDict[crka] + "|");
            }
            else if (crka == ' ')
            {
                preveden_string.Append(""); //skip presledkov
            }
            else
            {
                preveden_string.Append("........"); //nedovoljen znak
            }
        }

        return preveden_string.ToString();
    }

    private static string Prevedi_v_abecedo(string vnos)
    {
        StringBuilder preveden_string = new StringBuilder();

        foreach (char crka in vnos)
        {

            string tempstr = "";
            tempstr = tempstr + crka;
            
            if (crka == '|') //supposed to check when one letter ends doesnt work properly from here
            {
                var key = morseDict.FirstOrDefault(x => x.Value == tempstr).Key; //to naj bi bil reverse search in dictionary NO CLUE
                Console.WriteLine(tempstr); //test

            }

        }

        return key.ToString();
    }

}