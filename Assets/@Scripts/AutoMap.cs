using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMap : MonoBehaviour
{
    public GameObject Track;
    public float pipeSpeed = 5f;

    [SerializeField]private float maxXPosition = 32f;
    [SerializeField]private Vector3 startPosition = new Vector3(-32f, 0f, 0f);

    void Start()
    {
        Debug.Log(Track.transform.position.x + ", " + Track.transform.position.y);
    }
    void Update()
    {
        float moveOffset = pipeSpeed * Time.deltaTime;

        Track.transform.localPosition = new Vector3(
            Track.transform.localPosition.x + moveOffset, 
            Track.transform.localPosition.y, 
            Track.transform.localPosition.z
        );
        
        if (Track.transform.localPosition.x >= maxXPosition)
        {
            Track.transform.localPosition = startPosition;
        }
    }
}