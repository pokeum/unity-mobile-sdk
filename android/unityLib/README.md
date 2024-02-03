# Unity Library

![Generic badge](https://img.shields.io/badge/Unity-2022.1.12f1-black?logo=unity&logoColor=white.svg)

- **_Unity library for Android plugin location_**

    - Mac OS X

      ```
      /Applications/Unity/Hub/Editor/2022.1.12f1/PlaybackEngines/AndroidPlayer/Variations/il2cpp/Release/Classes/classes.jar
      ```

- **_`UnityPlayerActivity.java` location_**

    - Mac OS X

      ```
      /Applications/Unity/Hub/Editor/2022.1.12f1/PlaybackEngines/AndroidPlayer/Source/com/unity3d/player/UnityPlayerActivity.java
      ```
      
## Build

![Generic badge](https://img.shields.io/badge/Java-17-orange?logo=oracle&logoColor=white.svg)

```bash
JAVA_HOME=$JAVA_17_HOME
```

```bash
./gradlew :unityLib:clean &&\
./gradlew :unityLib:assembleRelease &&\
cp unityLib/build/outputs/aar/unityLib-release.aar plugin/libs/unity.aar
```
