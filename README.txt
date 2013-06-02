CW Library

Jeremiah Stoddard - AG6HC <ag6hc@arrl.net>

This is my personal library for working with Morse code. Presently it contains
the TextToMorse class which takes a string and returns a byte array in WAVE
file format containing the contents of the string translated into Morse code.
This is somewhat like what ebook2cw does, but not nearly as flexible (only
WAVE output rather than mp3 or ogg, a much more limited number of characters
supported). On the other hand, CWLibrary is written in C# using only the .NET
framework libraries, so if you're working on a .NET project it may be a better
fit for your needs...

Here is an example program that uses this library to write out a file named
"hello.wav" that plays "hello, world" in Morse code:

+-----------------------------------------------------------------------------+
using CWLibrary;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        TextToMorse converter = new TextToMorse();
        string text = "Hello, World";

        byte[] outfile = converter.ConvertToMorse(text);

        FileStream stream = new FileStream("hello.wav", FileMode.Create,
											FileAccess.Write);
        stream.Write(outfile, 0, outfile.Length);
        stream.Close();
    }
}
+-----------------------------------------------------------------------------+

The above program will generate 20 WPM Morse code with a pitch of 600Hz. If
you want 15 WPM, just pass it to the constructor:

         TextToMorse converter = new TextToMorse(15);

If you want 5/18 WPM (character speed as if sending at 18 WPM, but spacing
between characters and words added for an overall speed of 5 WPM) you would
call the constructor thus:

         TextToMorse converter = new TextToMorse(18, 5);

If you also wanted to raise the pitch to 800 Hz, the following would do so:

         TextToMorse converter = new TextToMorse(18, 5, 800.0);

The code is licensed under the MIT license, so you can do pretty much whatever
you want with it.

THANKS:

I ought to credit a specific series of articles that got me up and running
with the wave file format right away. These three blog posts on MSDN saved me
from many hours of trial and error:

http://blogs.msdn.com/b/dawate/archive/2009/06/22/intro-to-audio-programming-part-1-how-audio-data-is-represented.aspx
http://blogs.msdn.com/b/dawate/archive/2009/06/23/intro-to-audio-programming-part-2-demystifying-the-wav-format.aspx
http://blogs.msdn.com/b/dawate/archive/2009/06/24/intro-to-audio-programming-part-3-synthesizing-simple-wave-audio-using-c.aspx

Nevertheless, since I did things a little differently from the blog author, I
ran into a few issues which I was able to look into using wxHexEditor and
Audacity. A big thank you to all authors of Free and Open Source software!

LICENSE:

CW Library

Copyright © 2013 Jeremiah Stoddard

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the “Software”), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
