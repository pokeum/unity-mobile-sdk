using System;
using UnityEngine;

namespace CallbackFunction
{
    public class NoParamCallbackBridge : AndroidJavaProxy
    {
        private readonly Action _callback;
    
        public NoParamCallbackBridge(Action callback) : base("com.example.callbackfunction.NoParamCallback")
        {
            _callback = callback;
        }
    
        // This method will be invoked from the plugin
        public void Invoke() { _callback?.Invoke(); }
    }

    public class StringParamCallbackBridge : AndroidJavaProxy
    {
        private readonly Action<string> _callback;
    
        public StringParamCallbackBridge(Action<string> callback) : base("com.example.callbackfunction.StringParamCallback")
        {
            _callback = callback;
        }
    
        // This method will be invoked from the plugin
        public void Invoke(string arg) { _callback?.Invoke(arg); }
    }   
}