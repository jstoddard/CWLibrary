using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWLibrary
{
    static class Characters
    {
        public static Dictionary<string, string> Symbols = new Dictionary<string, string>()
        {
            { "a", ".-" },
            { "b", "-..." },
            { "c", "-.-." },
            { "d", "-.." },
            { "e", "." },
            { "f", "..-." },
            { "g", "--." },
            { "h", "...." },
            { "i", ".." },
            { "j", ".---" },
            { "k", "-.-" },
            { "l", ".-.." },
            { "m", "--" },
            { "n", "-." },
            { "o", "---" },
            { "p", ".--." },
            { "q", "--.-" },
            { "r", ".-." },
            { "s", "..." },
            { "t", "-" },
            { "u", "..-" },
            { "v", "...-" },
            { "w", ".--" },
            { "x", "-..-" },
            { "y", "-.--" },
            { "z", "--.." },
            { "0", "-----" },
            { "1", ".----" },
            { "2", "..---" },
            { "3", "...--" },
            { "4", "....-" },
            { "5", "....." },
            { "6", "-...." },
            { "7", "--..." },
            { "8", "---.." },
            { "9", "----." },
            { ".", ".-.-.-" },
            { ",", "--..--" },
            { "?", "..--.." },
            { "'", ".----." },
            { "/", "-..-." },
            { "(", "-.--." },
            { ")", "-.--.-" },
            { ":", "---..." },
            { ";", "-.-.-." },
            { "=", "-...-" },
            { "+", ".-.-." },
            { "-", "-....-" },
            { "\"", ".-..-." },
            { "@", ".--.-." },
            // Prosigns -- see
            // http://en.wikipedia.org/wiki/Prosigns_for_Morse_code
            { "<aa>", ".-.-" },         // Space down one line (new line)
            { "<ar>", ".-.-." },        // Stop copying (end of message)
            { "<as>", ".-..." },        // Stand by
            { "<bk>", "-...-.-" },      // Break
            { "<bt>", "-...-" },        // Space down two lines
            { "<cl>", "-.-..-.." },     // Clear (going off the air)
            { "<ct>", "-.-.-" },        // Start copying
            { "<kn>", "-.--." },        // Go only
            { "<sk>", "...-.-" },       // Silent key (going off the air)
            { "<sn>", "...-." }         // Understood
        };
    }
}
