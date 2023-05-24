using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject seb;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = seb.transform.position.x;
        transform.position = position;

        //Vector3 position = transform.position;
        position.y = seb.transform.position.y + 2.0f;
        transform.position = position;
    }
}
