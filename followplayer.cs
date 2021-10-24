using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    private Transform playerTransform;
    private Transform cameraTransform;
    private Vector3 offset = new Vector3 (0,1,-8);
    private void Start()
    {
        cameraTransform = this.gameObject.transform;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
   
    private void Update()
    {
        updatecameraposition();
    }
   void updatecameraposition()
    {
      
        cameraTransform.position = playerTransform.position + offset;
    }
}
