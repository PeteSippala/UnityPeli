using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public class movement : MonoBehaviour
{

    Rigidbody2D rgbd2d;
    Vector3 movementvector;
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

        movementvector *= speed;

        rgbd2d.velocity = movementvector;
    }
}
