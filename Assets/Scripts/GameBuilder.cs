#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public class GameBuilder : MonoBehaviour
{
    static void webGL() {
        string[] scenes = {"Assets/Scenes/level1.unity"};

        string pathToDeploy = "builds/WebGLVersion";

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
    }
    static void windows() {
        EditorBuildSettingsScene[] sceneList = EditorBuildSettings.scenes;

        string pathToDeploy = "builds/WindowsVersion";

        BuildPipeline.BuildPlayer(sceneList, pathToDeploy, BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}

#endif