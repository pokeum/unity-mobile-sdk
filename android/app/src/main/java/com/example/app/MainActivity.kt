package com.example.app

import android.os.Bundle
import android.util.Log
import androidx.appcompat.app.AppCompatActivity
import com.example.app.databinding.ActivityMainBinding
import com.example.callbackfunction.sdk.Plugin

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnTriggerCallback.setOnClickListener {
            Plugin.TestFunc(
                5000,
                { Log.d(TAG, "TestFunc OnSuccess Called!") },
                { Log.d(TAG, "TestFunc OnFailure Called! : ${it.message}") }
            )
        }
    }

    companion object {
        private const val TAG = "MainActivity"
    }
}