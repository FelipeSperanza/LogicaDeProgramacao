﻿using System.Globalization;

double A, B, C, media;

A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));