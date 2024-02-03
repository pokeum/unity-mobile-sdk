using UnityEngine;
using UnityEngine.UI;

namespace CallbackFunction
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private Button triggerCallbackButton;
        
        // Start is called before the first frame update
        void Start()
        {
            triggerCallbackButton.onClick.AddListener(OnTriggerCallbackButtonClick);
        }

        void OnTriggerCallbackButtonClick()
        {
            // Use Callback Function
            Plugin.CallTestFunc(
                delayMillis: 5000,
                onSuccess: () => {
                    Debug.Log("[Plugin] CallTestFunc OnSuccess Called!"); 
                }, 
                onFailure: (exception) => {
                    Debug.Log($"[Plugin] CallTestFunc OnFailure Called! : {exception.Message}");
                });
        }
    }
}