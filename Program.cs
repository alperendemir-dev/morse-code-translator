// See https://aka.ms/new-console-template for more information
using static System.Console;
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // 1) Morse-Dictionary anlegen
        var morse = new Dictionary<char, string>
        {
            {'A', ".-"},    {'B', "-..."},  {'C', "-.-."},  {'D', "-.."},
            {'E', "."},     {'F', "..-."},  {'G', "--."},   {'H', "...."},
            {'I', ".."},    {'J', ".---"},  {'K', "-.-"},   {'L', ".-.."},
            {'M', "--"},    {'N', "-."},    {'O', "---"},   {'P', ".--."},
            {'Q', "--.-"},  {'R', ".-."},   {'S', "..."},   {'T', "-"},
            {'U', "..-"},   {'V', "...-"},  {'W', ".--"},   {'X', "-..-"},
            {'Y', "-.--"},  {'Z', "--.."},
            {'0', "-----"}, {'1', ".----"},{'2', "..---"},{'3', "...--"},
            {'4', "....-"},{'5', "....."},{'6', "-...."},{'7', "--..."},
            {'8', "---.."},{'9', "----."},
            {' ', "/"}    // Worttrenner
        };

        // 2) Eingabe einlesen
        Write("Das ist ein Morse-Code-Übersetzer. Tipp was ein und ich übersetze es dir: ");
        string eingabe = ReadLine()
            .Trim()
            .ToUpper();    // auf Großbuchstaben, weil Dictionary so angelegt

        // 3) Übersetzen
        var sb = new StringBuilder();
        foreach (char c in eingabe)
        {
            if (morse.TryGetValue(c, out string code))
            {
                sb.Append(code);
                sb.Append(' ');   // Leerzeichen zwischen Buchstaben
            }
            else
            {
                sb.Append("? ");  // unbekanntes Zeichen
            }
        }

        // 4) Ausgabe
        WriteLine();
        WriteLine("Morse-Code:");
        WriteLine(sb.ToString().Trim());
    }
}

//So funktioniert’s kurz:

//Dictionary: Enthält alle Zuordnungen char → String.

//Eingabe: Lies den Text ein, trimme Leerzeichen und wand­le in Großbuchstaben um.

//Loop: Für jedes Zeichen schaust du im Dictionary nach dem Morse-Code.

//StringBuilder: Sammelt die Codes mit Leerzeichen dazwischen.

//Ausgabe: Gib den fertigen Morse-Code aus.

