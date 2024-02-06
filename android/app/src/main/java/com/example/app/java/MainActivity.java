package com.example.app.java;

import android.os.Bundle;
import android.util.Log;

import androidx.appcompat.app.AppCompatActivity;

import com.example.app.databinding.ActivityMainBinding;
import com.example.callbackfunction.sdk.Plugin;

public class MainActivity extends AppCompatActivity {

    private static final String TAG = MainActivity.class.getSimpleName();

    private ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        binding.btnTriggerCallback.setOnClickListener(view -> {
            Plugin.TestFunc(
                5000,
                () -> Log.d(TAG, "TestFunc OnSuccess Called!"),
                result -> Log.d(TAG, "TestFunc OnFailure Called! : " + result.getMessage())
            );
        });
    }
}