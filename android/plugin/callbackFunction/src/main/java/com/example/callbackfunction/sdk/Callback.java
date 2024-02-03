package com.example.callbackfunction.sdk;

@FunctionalInterface
public interface Callback<T> {
    void invoke(T result);
}