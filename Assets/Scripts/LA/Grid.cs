using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class Grid : MonoBehaviour
{
	public int numberOfLines = 20;
	public float distanceBetweenLines = 2.0f;
	public float lineWidth = 2.0f;
	public Transform tf;
	VectorLine line;

	void Start()
	{
		numberOfLines = Mathf.Clamp(numberOfLines, 2, 8190);
		var points = new List<Vector3>();
		// Lines down X axis
		for (int i = -numberOfLines; i < numberOfLines; i++)
		{
			points.Add(new Vector3(i * distanceBetweenLines, 0, -numberOfLines * distanceBetweenLines));

			points.Add(new Vector3(i * distanceBetweenLines, 0, (numberOfLines) * distanceBetweenLines));
		}
		// Lines down Z axis
		for (int i = -numberOfLines; i < numberOfLines; i++)
		{
			points.Add(new Vector3(-numberOfLines * distanceBetweenLines, 0, i * distanceBetweenLines));
			points.Add(new Vector3((numberOfLines) * distanceBetweenLines, 0, i * distanceBetweenLines));
		}
		line = new VectorLine("Grid", points, lineWidth);
		line.lineWidth = 3.0f;
		line.SetColor(Color.green);
		line.Draw3DAuto();
		line.rectTransform.anchoredPosition = new Vector3(0, 0, 0);
		line.drawTransform = tf;
	}
}
