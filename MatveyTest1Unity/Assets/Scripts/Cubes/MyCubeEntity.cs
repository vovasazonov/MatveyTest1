using UnityEngine;
using UnityEngine.UI;

namespace Cubes
{
    public class MyCubeEntity : MonoBehaviour
    {
        [SerializeField] private Text _boardText;

        private int[,] _someInts =
        {
            { 0, 5, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 5 }
        };


        private void Update()
        {
            _someInts[0, 0] = _someInts[0, 0] + 1; 
            PrintToTextUI();
        }

        private void PrintToTextUI()
        {
            string board = "";

            for (int y = 0; y < _someInts.GetLength(0); y++)
            {
                board = board + "\n";

                for (int x = 0; x < _someInts.GetLength(1); x++)
                {
                    board = board + $"[{_someInts[y, x]}]";
                }
            }

            _boardText.text = board;
        }
    }
}