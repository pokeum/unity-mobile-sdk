using UnityEngine;
using UnityEngine.UI;

namespace iOSTest
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private Button triggerCallbackButton;
        
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("We are here");
            FrameworkBridge.Hello();
            FrameworkBridge.Message("Hello from Unity!");

            FrameworkBridge.InitializeDelegate();
            
            triggerCallbackButton.onClick.AddListener(OnTriggerCallbackButtonClick);
        }

        void OnTriggerCallbackButtonClick()
        {
            FrameworkBridge.AskDelegateForNumber();
        }
    }
}