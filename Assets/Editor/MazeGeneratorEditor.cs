using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MazeGenerator))]
public class MazeGeneratorEditor : Editor {
	public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        MazeGenerator mazeScript = (MazeGenerator)target;
        if(GUILayout.Button("Build Maze"))
        {
            mazeScript.CreateMaze();
        }
    }

}
