using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class SaveLineMeshFile : Editor
{
    static List<Vector3> vertices;
    static List<int> lineSegments;

    [MenuItem ("CONTEXT/LineModelRenderer/Save Mesh")]
    static void SaveMeshFile( ) {
        GameObject go = Selection.activeGameObject;

        AssetDatabase.CreateAsset( go.GetComponent<MeshFilter>().mesh, "Assets/" + go.name + ".asset" );
        AssetDatabase.SaveAssets();
    }
}
