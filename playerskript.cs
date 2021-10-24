using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerskript : MonoBehaviour
{
    private Rigidbody playerrigidBody;

    [Header("forward axis controll")]
    public float magnitude;
    private Vector3 direction = new Vector3(0, 0, 1);

    [Header("movement axis controll")]
    public float sidemagnitude;
    private Vector3 sidedirection = new Vector3(1, 0, 0);


    [Header("jump axis controll")]
    public float jumpmagnitude;
    private Vector3 jumpdirection = new Vector3(0, 1, 0);
    bool isgrouded;
    private void Start()
    {
        playerrigidBody = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        addforceAlongz();
        checkplayeryaxis();
        updateXaxis();
        jumpupdate();

    }

    private void updateXaxis()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerrigidBody.AddForce(sidedirection * sidemagnitude, ForceMode.Force);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            playerrigidBody.AddForce(-sidedirection * sidemagnitude, ForceMode.Force);
        }

    }
    private void jumpupdate()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            playerrigidBody.AddForce(jumpdirection * jumpmagnitude, ForceMode.Force);
            isgrouded = false;
        }
    }
    private void checkplayeryaxis()
    {
        if (gameObject.transform.position.y < -3)
            gameObject.SetActive(false);
    }

    public void addforceAlongz()
    {
        playerrigidBody.AddForce(direction * magnitude, ForceMode.Force);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("f hggfh");
            this.gameObject.SetActive(false);
        }
            
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
            isgrouded = true;
            
    }

   
}

