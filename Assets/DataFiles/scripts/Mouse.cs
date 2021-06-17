using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private GameObject activeGameobject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        activeGameobject = Camera.main.gameObject;
        Debug.Log("you clicked mouse");
    }
}