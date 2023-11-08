using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public class movement : MonoBehaviour
{

    Rigidbody2D rgbd2d;
    [HideInInspector]
    public Vector3 movementvector;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;

    [SerializeField] float speed = 3f;

    private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        movementvector = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        movementvector.x = Input.GetAxisRaw("Horizontal");
        movementvector.y = Input.GetAxisRaw("Vertical");
        if(movementvector.x != 0)
        {
            lastHorizontalVector= movementvector.x;
        }
        if(movementvector.y != 0)
        {
            lastVerticalVector = movementvector.y;
        }

        movementvector *= speed;

        rgbd2d.velocity = movementvector;
    }
}
