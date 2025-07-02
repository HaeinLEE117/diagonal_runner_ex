using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LoopHurdle : MonoBehaviour
{
    public GameObject Hurdle;
    public float moveSpeed = 5f;

    [SerializeField]private float maxXPosition = 16f;
    private Vector2[] startPositions =
    {
        new Vector2(-27.62f, 22.95f),
        new Vector2(-26.735f, 23.378f),
        new Vector2(-26.14f, 24.09f),
        new Vector2(-25.47f, 24.73f),
        new Vector2(-24.04f, 25.32f),
        new Vector2(-23.96f, 25.78f),
    };

    void Update()
    {
        float moveOffset = moveSpeed * Time.deltaTime;

        Hurdle.transform.localPosition = new Vector3(
            Hurdle.transform.localPosition.x + moveOffset, 
            Hurdle.transform.localPosition.y - moveOffset, 
            Hurdle.transform.localPosition.z
        );
        
        if (Hurdle.transform.localPosition.x >= maxXPosition)
        {
            ResetHurdle();
        }
    }

    void ResetHurdle()
    {
        int positionIndex = Random.Range(0, startPositions.Length);
        int randOffset = Random.Range(0, 3);
        
        Hurdle.transform.localPosition =  new Vector3(startPositions[positionIndex].x + randOffset ,startPositions[positionIndex].y - randOffset,0);
        
    }
}