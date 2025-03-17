﻿string fraseDigitada, fraseComDislalia;

Console.Write("   O rato roeu a roupa do rei de roma ");
fraseDigitada = ("   O rato roeu a roupa do rei de roma ");

fraseComDislalia = fraseDigitada
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine(fraseComDislalia);
