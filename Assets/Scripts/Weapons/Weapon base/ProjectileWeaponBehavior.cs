using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ProjectileWeaponBehavior : MonoBehaviour
{
    protected UnityEngine.Vector3 direction;
    public float destroyAfterSeconds;
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(UnityEngine.Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;
        
        UnityEngine.Vector3 scale = transform.localScale;
        UnityEngine.Vector3 rotation = transform.rotation.eulerAngles;

        if(dirx < 0 && diry == 0) //Left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }
        else if (dirx == 0 && diry < 0) //Down
        {
            scale.y = scale.y * -1;
        }
        else if (dirx > 0 && diry > 0) // Up
        {
            scale.x = scale.x * -1;
        }
        else if (dirx > 0 && diry > 0) //Right up
        {
            rotation.z = 0f;
        }
        else if (dirx > 0 && diry < 0) //Right down
        {
            rotation.z = -90f;
        }
        else if (dirx < 0 && diry < 0) //Left up
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = 0f;
        }
        else if (dirx < 0 && diry > 0) //Left down
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            rotation.z = -90f;
        }
        

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
