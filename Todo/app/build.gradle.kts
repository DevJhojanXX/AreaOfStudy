plugins {
    alias(libs.plugins.androidApplication)
    alias(libs.plugins.jetbrainsKotlinAndroid)
    id("com.google.devtools.ksp") version "1.8.10-1.0.9" apply false
}

android {
    namespace = "com.jdtp.todo"
    compileSdk = 34

    defaultConfig {
        applicationId = "com.jdtp.todo"
        minSdk = 21
        targetSdk = 34
        versionCode = 1
        versionName = "1.0"
        testInstrumentationRunner = "androidx.test.runner.AndroidJUnitRunner"


    }

    buildTypes {
        release {
            isMinifyEnabled = false
            proguardFiles(
                getDefaultProguardFile("proguard-android-optimize.txt"),
                "proguard-rules.pro"
            )
        }
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_1_8
        targetCompatibility = JavaVersion.VERSION_1_8
    }
    kotlinOptions {
        jvmTarget = "1.8"
    }
}

dependencies {
    implementation(libs.transport.runtime)
    val room_version = "2.6.1"
    implementation(libs.androidx.activity)
    implementation(libs.androidx.constraintlayout)
    implementation(String.format("androidx.room:room-runtime:$room_version"))
    annotationProcessor(String.format("androidx.room:room-compiler:$room_version"))
    implementation(String.format("androidx.room:room-ktx:$room_version"))
    implementation(libs.androidx.appcompat)
    implementation(libs.material)
    testImplementation(libs.junit)
    androidTestImplementation(libs.androidx.junit)
    androidTestImplementation(libs.androidx.espresso.core)
    implementation(String.format("com.google.dagger:hilt-android:2.44"))
}