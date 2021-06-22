using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public float movespeed = 35.0f;
    public float minimumDistanceFromTarget = 5f;
    public GameObject targetobject;
    private bool movingtowardstarget = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(movingtowardstarget == true)
            {
                movingtowardstarget = false;

            }
            else
            {
                movingtowardstarget = true;
            }
        }
    }

    public void movetowardstarget(GameObject target)
    {
        if (Vector3.Distance(transform.position, target.transform.position) > minimumDistanceFromTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movespeed * Time.deltaTime);
        } else
        {
            movingtowardstarget = false;

        }
    }
}       