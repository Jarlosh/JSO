using UnityEngine;

namespace _00_Game.Scripts.SOs.SOs
{
    [CreateAssetMenu(fileName = "RootSO", menuName = "SO/RootSO", order = 0)]
    public class RootSO : ScriptableObject
    {
        public int rootInt = 1;
        public RootSO root;
    }
}