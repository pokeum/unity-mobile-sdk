# Unity Mobile SDK
![Generic badge](https://img.shields.io/badge/Unity-2022.1.12f1-black?logo=unity&logoColor=white.svg)

## Android Environment

- [Unity Library](./android/unityLib/)
- [Android Plugin](./android/plugin/)

## Callback Function

### Unity

- _C#_
  ```csharp
  Plugin.CallTestFunc(
    delayMillis: 5000,
    onSuccess: () => {
      Debug.Log("[Plugin] CallTestFunc OnSuccess Called!"); 
    }, 
    onFailure: (exception) => {
      Debug.Log($"[Plugin] CallTestFunc OnFailure Called! : {exception.Message}");
    }
  );
  ```

### Android

- _Kotlin_
  ```kotlin
  Plugin.TestFunc(
    /* delayMillis  : */ 5000,
    /* onSuccess    : */ { Log.d(TAG, "TestFunc OnSuccess Called!") },
    /* onFailure    : */ { Log.d(TAG, "TestFunc OnFailure Called! : ${it.message}") }
  )
  ```
- _Java_
  ```java
  Plugin.TestFunc(
    /* delayMillis  : */ 5000,
    /* onSuccess    : */ () -> Log.d(TAG, "TestFunc OnSuccess Called!"),
    /* onFailure    : */ result -> Log.d(TAG, "TestFunc OnFailure Called! : " + result.getMessage())
  );
  ```

### iOS

### Reference
- [How to Create Android Java Callbacks to C# in Unity](https://vuopaja.com/tutorials/android-proxy.html)
  // [![GH Pages](https://img.shields.io/badge/GitHub-vuopaja/android--java--proxy-blue?logo=github&logoColor=white)](https://github.com/vuopaja/android-java-proxy)
- [Integrating native iOS code into Unity](https://medium.com/@rolir00li/integrating-native-ios-code-into-unity-e844a6131c21)
