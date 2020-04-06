﻿using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.ObserverPattern.Core;

namespace ProjectOne.ObserverPattern
{
    public class Spreadsheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Spreadsheet was updated.");

        }
    }
}
