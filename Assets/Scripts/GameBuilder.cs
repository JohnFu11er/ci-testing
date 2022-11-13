#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public class GameBuilder : MonoBehaviour
{
    static void webGL() {
        EditorBuildSettingsScene[] sceneList = EditorBuildSettings.scenes;

        string pathToDeploy = "~/unitybuilds/WebGLVersion";

        BuildPipeline.BuildPlayer(sceneList, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
    }
    static void windows() {
        EditorBuildSettingsScene[] sceneList = EditorBuildSettings.scenes;

        string pathToDeploy = "~/unitybuilds/WindowsVersion";

        BuildPipeline.BuildPlayer(sceneList, pathToDeploy, BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}

#endif