using GraphMentor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static.Nodes
{
    public abstract class Ast : Node
    {
        protected Ast(vec position, int length, vec smoothActivation, vec smoothDelay, ActivationFunc activationFunc, DelayFunc delayFunc, Sensitivity m_sensitivity, Sensitivity s_sensitivity, Sensitivity r_Sensitivity, AggFunc m_aggFunc, AggFunc s_aggFunc, AggFunc r_AggFunc, AggFunc stateAggFunc, matrix m_weights, matrix s_weights, matrix r_Weights, matrix weights, SigmaFunc sigmaFunc, RangeResolver rangeResolver, Slice slice) : base(position, length, smoothActivation, smoothDelay, activationFunc, delayFunc, m_sensitivity, s_sensitivity, r_Sensitivity, m_aggFunc, s_aggFunc, r_AggFunc, stateAggFunc, m_weights, s_weights, r_Weights, weights, sigmaFunc, rangeResolver, slice)
        {
        }
    }
}
