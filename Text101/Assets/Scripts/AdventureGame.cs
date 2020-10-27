using UnityEngine;
using UnityEngine.UI;

namespace Text101
{
    public class AdventureGame : MonoBehaviour
    {
        [SerializeField] private Text _textComponent;
        [SerializeField] private State _startingState;

        private State _state;

        // Start is called before the first frame update
        private void Start()
        {
            _state = _startingState;
            _textComponent.text = _state.GetStateStory();
        }

        // Update is called once per frame
        private void Update()
        {
            ManageState();
        }

        private void ManageState()
        {
            var nextStates = _state.GetNextStates();

            for (int i = 0; i < nextStates.Length; i++)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                {
                    _state = nextStates[i];
                }
            }

            _textComponent.text = _state.GetStateStory();
        }
    }
}
