using GraphMentor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static
{
    public abstract class ActivationFunc
    {
        public abstract bool Activate(vec smoothActivation, vec value, vec state);
    }
}
