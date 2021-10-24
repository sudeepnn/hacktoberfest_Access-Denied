using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complete : MonoBehaviour
{
    public Gamemanager managerInstance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            managerInstance.completescene();
    }
}
