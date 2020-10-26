using UnityEngine;

namespace Text101
{
    [CreateAssetMenu(menuName = "State")]
    public class State : ScriptableObject
    {
        [TextArea(14, 10)] [SerializeField] private string _storyText;
        [SerializeField] private State[] _nextStates;

        public string GetStateStory()
        {
            return _storyText;
        }

        public State[] GetNextStates()
        {
            return _nextStates;
        }
    }
}
