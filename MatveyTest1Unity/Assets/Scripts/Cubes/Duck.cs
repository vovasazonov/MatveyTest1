using UnityEngine;

namespace Cubes
{
    public class Duck : IVoicable, IFlyable
    {
        public void DoVoice()
        {
            Debug.Log("Crack crack");
        }

        public void Fly()
        {
            Debug.Log("wing wing");
        }
    }
}