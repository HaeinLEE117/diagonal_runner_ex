using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class LoopMap : MonoBehaviour
{
    public GameObject Track;
    public float moveSpeed = 5f;

    [SerializeField]private float maxXPosition = 32f;
    [SerializeField]private Vector3 startPosition = new Vector3(-32f, 0f, 0f);

    void Update()
    {
        float moveOffset = moveSpeed * Time.deltaTime;

        Track.transform.localPosition = new Vector3(
            Track.transform.localPosition.x + moveOffset, 
            Track.transform.localPosition.y , 
            Track.transform.localPosition.z
        );
        
        if (Track.transform.localPosition.x >= maxXPosition)
        {
            Track.transform.localPosition = startPosition;
        }
    }
    
    
}