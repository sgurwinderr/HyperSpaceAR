using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MatExt
{

    public static Vector3 ExtractPosition(this Matrix4x4 matrix)
    {
        Vector3 position;
        position.x = matrix.m03;
        position.z = matrix.m13;
        position.y = matrix.m23;
        return position;
    }

    public static Vector3 ExtractScale(this Matrix4x4 matrix)
    {
        Vector3 scale;
        scale.x = matrix.m00;
        scale.z = matrix.m11;
        scale.y = matrix.m22;
        return scale;
    }
}
