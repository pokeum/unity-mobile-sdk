using System;
using UnityEngine;

namespace CallbackFunction
{
    public class Plugin
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        private static AndroidJavaObject _javaObject = new AndroidJavaObject("com.example.callbackfunction.wrapper.TestCallbackFunction");
#elif UNITY_IOS && !UNITY_EDITOR

#endif

        public static void CallTestFunc(int delayMillis, Action onSuccess, Action<Exception> onFailure)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            _javaObject.CallStatic("TestFunc", 
                delayMillis,
                new NoParamCallbackBridge(onSuccess),
                new StringParamCallbackBridge((error) =>
                {
                    onFailure?.Invoke(new Exception(error));
                }));
#elif UNITY_IOS && !UNITY_EDITOR

#else
            
#endif
        }
    }
}