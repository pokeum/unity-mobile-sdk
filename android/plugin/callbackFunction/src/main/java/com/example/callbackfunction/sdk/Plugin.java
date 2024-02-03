package com.example.callbackfunction.sdk;

import android.util.Log;
import java.util.Random;

public class Plugin {

    private static int counter = 0;

    private static final String TAG = "Native";

    public static void TestFunc(
            int delayMillis,
            UnitCallback onSuccess,
            Callback<Throwable> onFailure
    ) {
        int id = counter++;
        Log.d(TAG, "[Plugin] TestFunc Called #" + id);

        new Thread(() -> {
            try { Thread.sleep(delayMillis); }
            catch (InterruptedException ignore) { }

            // OnSuccess
            if ((new Random()).nextBoolean()) {
                Log.d(TAG, "[Plugin] TestFunc OnSuccess Called! #" + id);
                onSuccess.invoke();
            }
            // OnFailure
            else {
                Exception e = new Exception("CUSTOM EXCEPTION");
                Log.d(TAG, "[Plugin] TestFunc OnFailure Called! #" + id + " : " + e.getMessage());
                onFailure.invoke(e);
            }
        }).start();
    }
}
