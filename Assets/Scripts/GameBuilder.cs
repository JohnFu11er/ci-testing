#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public class GameBuilder : MonoBehaviour
{
    static void webGL() {
        string[] scenes = {"./Assets/Scenes/level1.unity"};

        string pathToDeploy = "./builds/WebGLVersion";

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
    }
    static void windows() {
        string[] scenes = {"./Assets/Scenes/level1.unity"};

        string pathToDeploy = "./builds/WindowsVersion";

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.StandaloneWindows, BuildOptions.None);

    }
    static void android() {
        string[] scenes = {"./Assets/Scenes/level1.unity"};

        string pathToDeploy = "./builds/AndroidVersion";

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.Android, BuildOptions.None);
    }
}

#endif