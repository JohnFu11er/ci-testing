#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public class WebGLBuilder : MonoBehaviour
{
    static void build() {
        EditorBuildSettingsScene[] sceneList = EditorBuildSettings.scenes;

        string pathToDeploy = "builds/WebGLVersion";

        BuildPipeline.BuildPlayer(sceneList, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
    }
}

#endif