package com.example.callbackfunction.wrapper;

import com.example.callbackfunction.sdk.Plugin;

public class TestCallbackFunction {

    public static void TestFunc(
            int delayMillis,
            NoParamCallback onSuccess,
            StringParamCallback onFailure
    ) {
        Plugin.TestFunc(
            delayMillis,
            onSuccess::Invoke,
            result -> { onFailure.Invoke(result.getMessage()); }
        );
    }
}