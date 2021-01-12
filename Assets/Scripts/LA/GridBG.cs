using System;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;
public class GridBG : MonoBehaviour
{
    public int gridPixels = 10;
    private VectorLine gridLine,axis;
    public Matrix4x4 mat;
    List<Vector2> points = new List<Vector2>();
    List<Vector2> ptaxis = new List<Vector2>();

    void Start()
    {
        VectorLine.canvas.sortingOrder = -1;
        
        points.Add(new Vector2(0, 0));
        gridLine = new VectorLine("Grid", points, 2f);
        axis = new VectorLine("Axis", ptaxis, 5f);
        gridLine.rectTransform.anchoredPosition = new Vector2(Screen.width/2, Screen.height/2);
        //axis.rectTransform.anchoredPosition = new Vector2(Screen.width / 2, Screen.height / 2);
        mat = Matrix4x4.identity;
        MakeGrid();
        DrawAxis();
    }

    private void TransformGrid()
    {
        gridLine.matrix = mat;
        gridLine.Draw();
    }

    void MakeGrid()
    {
        int numberOfGridPoints = ((Screen.width / gridPixels + 1) + (Screen.height / gridPixels + 1)) * 6;
        gridLine.Resize(numberOfGridPoints);
        DrawGrid();
        TransformGrid();
    }

    private void DrawAxis()
    {
        ptaxis.Add(new Vector2(Screen.width / 2, Screen.height / 2));
        ptaxis.Add(new Vector2(Screen.width / 2, (Screen.height/2)+1*gridPixels));
        axis.SetColor(Color.green,0);
        ptaxis.Add(new Vector2(Screen.width / 2, Screen.height / 2));
        ptaxis.Add(new Vector2((Screen.width/2)+1*gridPixels, Screen.height / 2));
        axis.SetColor(Color.red, 1);
        axis.Draw();
    }

    void DrawGrid()
    {
        int index = 0;
        // 1 V
        for (int x = 0; x < Screen.width / 2; x += gridPixels)
        {
            gridLine.points2[index++] = new Vector2(x, 0);
            gridLine.points2[index++] = new Vector2(x, (Screen.height/2));
        }

        // 1 H
        for (int y = 0; y < Screen.height / 2; y += gridPixels)
        {
            gridLine.points2[index++] = new Vector2(0, y);
            gridLine.points2[index++] = new Vector2((Screen.width/2), y);
        }

        // 2 V
        for (int x = 0; x > -Screen.width / 2; x -= gridPixels)
        {
            gridLine.points2[index++] = new Vector2(x, 0);
            gridLine.points2[index++] = new Vector2(x, (Screen.height/2));
        }
        
        // 2 H
        for (int y = 0; y < Screen.height / 2; y += gridPixels)
        {
            gridLine.points2[index++] = new Vector2(0, y);
            gridLine.points2[index++] = new Vector2((-Screen.width/2), y);
        }

        // 3 V
        for (int x = 0; x > -Screen.width / 2; x -= gridPixels)
        {
            gridLine.points2[index++] = new Vector2(x, 0);
            gridLine.points2[index++] = new Vector2(x, (-Screen.height/2));
        }

        // 3 H
        for (int y = 0; y > -Screen.height / 2; y -= gridPixels)
        {
            gridLine.points2[index++] = new Vector2(0, y);
            gridLine.points2[index++] = new Vector2((-Screen.width/2), y);
        }

        
        // 4 V
        for (int x = 0; x < Screen.width / 2; x += gridPixels)
        {
            gridLine.points2[index++] = new Vector2(x, 0);
            gridLine.points2[index++] = new Vector2(x, (-Screen.height/2));
        }

        // 4 H
        for (int y = 0; y > -Screen.height / 2; y -= gridPixels)
        {
            gridLine.points2[index++] = new Vector2(0, y);
            gridLine.points2[index++] = new Vector2((Screen.width/2), y);
        }

    }
}
