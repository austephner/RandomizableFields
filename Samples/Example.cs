using System;
using UnityEngine;

namespace RandomizableFields.Samples
{
    public class Example : MonoBehaviour
    {
        [Randomizable(0.0f, 1.0f)] [SerializeField] 
        private float _randomFloat; 

        [Randomizable(0, 100)] [SerializeField] 
        private int _randomInt;

        [RandomizableGuid] [SerializeField] 
        private string _randomGuid = Guid.NewGuid().ToString();
    }
}