﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cow:Animal
    {
        public Cow() {
            Name = "Cow";
        }
        public override void Speak()
        {
            Speak("Moooooooooooo!");
        }
    }
}
