using System;
using UnityEngine;

namespace RandomizableIntFields
{
    [AttributeUsage(AttributeTargets.Field)]
    public class RandomizableAttribute : PropertyAttribute
    {
	    private float _min = 0, _max = 0;

        public float min => _min;

        public float max => _max;

        public RandomizableAttribute(float max)
        {
	        this.
	        _max = max;
        }

        public RandomizableAttribute(float min, float max)
        {
	        _min = min;
	        _max = max;
        }
    }
}