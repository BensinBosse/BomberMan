using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explotion : MonoBehaviour
{
    public Collider BombCollider;

    
    public GameObject laserPrefab;

    public float duration;

    private void OnTriggerExit(Collider other)
    {
        this.BombCollider.isTrigger = false;
    }

    public void Explode()
    {
        GameObject laser = Instantiate(laserPrefab, this.gameObject.transform.position, Quaternion.identity) as GameObject;
        Destroy(laser, this.duration);
        CreateExplotions (Vector2.left);
        CreateExplotions (Vector2.right);
        CreateExplotions (Vector2.up);
        CreateExplotions (Vector2.down);

        Destroy(this.gameObject);

    }


    public void CreateExplotions()
    {

    }

}
