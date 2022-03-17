using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{


    public int hazardDamage;



    void OnCollisionEnter3D(Collision collisionData)
    {

        Collider objectWeCollidedWith = collisionData.collider;

        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();


        if (player != null)
        {



            player.ChangeHealth(-hazardDamage);
        }
    }
}