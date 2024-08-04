using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class DrawRoom : MonoBehaviour
{
    Mesh[] meshes;
    Matrix4x4 matrix4X4;
    private void Start()
    {
        matrix4X4 = Matrix4x4.TRS
        Graphics.RenderMeshInstanced()
    }
    
}
