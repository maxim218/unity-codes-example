using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour {
    public GameObject line;
    
    private void Start() {
        // scale
        line.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        // component
        var lineRenderer = line.GetComponent<LineRenderer>();
        // points number
        lineRenderer.positionCount = 5;
        // positions of points
        lineRenderer.SetPosition(0, new Vector3(8, 5, 0));
        lineRenderer.SetPosition(1, new Vector3(-8, 2, 0));
        lineRenderer.SetPosition(2, new Vector3(8, -1, 0));
        lineRenderer.SetPosition(3, new Vector3(-8, -4, 0));
        lineRenderer.SetPosition(4, new Vector3(8, -7, 0));
        // color
        lineRenderer.startColor = Color.green;
        lineRenderer.endColor = Color.green;
        // width
        lineRenderer.startWidth = 0.2f;
        lineRenderer.endWidth = 0.2f;
        // params
        lineRenderer.numCornerVertices = 20;
        lineRenderer.numCapVertices = 20;
    }
}
