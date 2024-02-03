plugins {
    id("com.android.library")
}

android {
    namespace = "com.example.callbackfunction"
    compileSdk = 34

    defaultConfig {
        minSdk = 22

        testInstrumentationRunner = "androidx.test.runner.AndroidJUnitRunner"
    }

    buildTypes {
        release {
            isMinifyEnabled = false
            proguardFiles(getDefaultProguardFile("proguard-android-optimize.txt"))
        }
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_1_8
        targetCompatibility = JavaVersion.VERSION_1_8
    }
}

dependencies {
    compileOnly(files("../libs/unity.aar"))

    implementation("androidx.appcompat:appcompat:1.6.1")
}

tasks.register("exportJar", Copy::class) {
    from("build/intermediates/aar_main_jar/release/")
    into("build/outputs/lib")
    include("classes.jar")
    rename("classes.jar", "AndroidCallbackFunction.jar")
}

tasks.register("clearJar", Delete::class) {
    delete("build/outputs/lib/AndroidCallbackFunction.jar")
}

tasks.named("exportJar") {
    dependsOn("clearJar", "build")
}