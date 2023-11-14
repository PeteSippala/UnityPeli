using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Character c = collision.GetComponent<Character>();
        if (c != null)
        {
            GetComponent<IPickUpObject>().OnPickUp(c);
            Destroy(gameObject);
        }
    }
}
