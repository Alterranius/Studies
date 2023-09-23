using GraphMentor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static
{
    public abstract class Mixer
    {
        public abstract vec Mix(matrix W, vec state, vec s, vec m, vec r);
    }
}
