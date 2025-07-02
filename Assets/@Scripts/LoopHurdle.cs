using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LoopHurdle : MonoBehaviour
{
    public float moveSpeed = 5f;

    [SerializeField]private float maxXPosition = 16f;
    private Vector2[] startPositions =
    {
        new Vector2(-14.49f, 9.51f),
        new Vector2(-13.104f, 10.749f),
        new Vector2(-13.8f, 10.14f),
        new Vector2(-12.456f, 11.358f),
        new Vector2(-11.778f, 11.987f),
        new Vector2(-11.109f, 12.596f),
    };

    void Update()
    {
        float moveOffset = moveSpeed * Time.deltaTime;

        transform.localPosition = new Vector3(
            transform.localPosition.x + moveOffset, 
            transform.localPosition.y - moveOffset, 
            transform.localPosition.z
        );
        
        if (transform.localPosition.x >= maxXPosition)
        {
            ResetHurdle();
        }
    }

    void ResetHurdle()
    {
        int positionIndex = Random.Range(0, startPositions.Length);
        int randOffset = Random.Range(0, 9);
        
        transform.localPosition =  new Vector3(startPositions[positionIndex].x + randOffset ,startPositions[positionIndex].y - randOffset,0);
        
    }
}