using System.Runtime.InteropServices;
using AOT;
using UnityEngine;

namespace iOSTest
{
    public class FrameworkBridge : MonoBehaviour
    {
#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern void framework_hello();

        [DllImport("__Internal")]
        private static extern void framework_message(string message);
        
        [DllImport("__Internal")]
        private static extern void framework_trigger_delegate();
        
        [DllImport("__Internal")]
        private static extern void framework_set_delegate(DelegateMessage callback);

        private delegate void DelegateMessage(int number);
        
        // https://docs.unity3d.com/kr/2019.4/Manual/TroubleShootingIPhone.html
        [MonoPInvokeCallback(typeof(DelegateMessage))]
        private static void DelegateMessageReceived(int number)
        {
            Debug.Log($"Message received: {number}");
        }
#endif

        public static void Hello()
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                framework_hello();
            }
#endif
        }

        public static void Message(string message)
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                framework_message(message);
            }
#endif
        }
        
        public static void AskDelegateForNumber()
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                framework_trigger_delegate();
            }
#endif
        }
    
        public static void InitializeDelegate()
        {
#if UNITY_IOS
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                framework_set_delegate(DelegateMessageReceived);
            }
#endif
        }
    }
}