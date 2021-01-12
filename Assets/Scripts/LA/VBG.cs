using System.Collections.Generic;
using UnityEngine;
using Vectrosity;
public class VBG : MonoBehaviour
{
    public int gridPixels = 10;
    private VectorLine gridLine;
    public Matrix4x4 mat;
    void Start()
    {
        List<Vector2> points = new List<Vector2>();
        points.Add(new Vector2(0, 0));
        gridLine = new VectorLine("Grid", points, 2f);
        MakeGrid();
    }

    private void TransformGrid()
    {
        gridLine.matrix = mat;
        gridLine.Draw();
    }

    void MakeGrid()
    {
        int numberOfGridPoints = 4;
        gridLine.Resize(numberOfGridPoints);

        gridLine.points2[0] = new Vector2(0, 0);

        TransformGrid();
    }

}
