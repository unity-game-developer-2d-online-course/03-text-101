using UnityEngine;
using UnityEngine.UI;

namespace Text101
{
    public class AdventureGame : MonoBehaviour
    {
        [SerializeField] private Text _textComponent;

        // Start is called before the first frame update
        private void Start()
        {
            _textComponent.text = "I am added programmatically!";
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}
