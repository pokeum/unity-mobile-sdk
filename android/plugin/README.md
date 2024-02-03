# Android Plugin

## build.gradle

- **_kotlin_**

    ```
    dependencies { 
        compileOnly(files("../libs/unity.aar"))
    
        ...
    }
      
    tasks.register("exportJar", Copy::class) {
        from("build/intermediates/aar_main_jar/release/")
        into("build/outputs/lib")
        include("classes.jar")
        rename("classes.jar", "{PLUGIN_NAME}.jar")
    }

    tasks.register("clearJar", Delete::class) {
        delete("build/outputs/lib/{PLUGIN_NAME}.jar")
    }

    tasks.named("exportJar") {
        dependsOn("clearJar", "build")
    }
    ```
      
## Build

![Generic badge](https://img.shields.io/badge/Java-17-orange?logo=oracle&logoColor=white.svg)

```bash
JAVA_HOME=$JAVA_17_HOME
```

```bash
$ ./gradlew :plugin:{MODULE}:clean
$ ./gradlew :plugin:{MODULE}:exportJar
```
