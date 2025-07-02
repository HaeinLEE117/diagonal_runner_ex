using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform playerTransform;
    private Vector2[] playerPositions =
    {
        new Vector2(1.17f,-4.24f),
        new Vector2(1.17f,-2.99f),
        new Vector2(1.17f,-1.68f),
        new Vector2(1.17f,-0.34f),
        new Vector2(1.17f,0.94f),
        new Vector2(1.17f,2.53f),
    };
    private int positionIndex = 0;

    void Start()
    {
        playerTransform = gameObject.GetComponent<Transform>();
    }

    public void GoUpPosition()
    {
        if (positionIndex >= playerPositions.Length - 1)
            return;
        positionIndex++;
        playerTransform.position = playerPositions[positionIndex];
    }

    public void GoDownPosition()
    {
        if (positionIndex <= 0)
            return;
        positionIndex--;
        playerTransform.position = playerPositions[positionIndex];
    }
    
}
