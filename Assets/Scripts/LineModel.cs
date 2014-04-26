using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LineModel : ScriptableObject
{
    [SerializeField]
    public Vector3[] vertices;
    [SerializeField]
    public int[] lineSegments;
}
