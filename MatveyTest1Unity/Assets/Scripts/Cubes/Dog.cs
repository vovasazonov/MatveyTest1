using UnityEngine;

namespace Cubes
{
    public class Dog : IVoicable
    {
        public void DoVoice()
        {
            Debug.Log("Bark bark");
        }
    }
}