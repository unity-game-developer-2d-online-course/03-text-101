﻿using UnityEngine;
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

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _state = nextStates[0];
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _state = nextStates[1];
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _state = nextStates[2];
            }

            _textComponent.text = _state.GetStateStory();
        }
    }
}
