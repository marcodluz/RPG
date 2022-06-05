using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;
    private Rigidbody bulletRigidbody;

    private void Awake() {
        bulletRigidbody = GetComponent<Rigidbody>();
    }

    private void Start() {
        float speed = 10f;
        bulletRigidbody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<BulletTarget>() != null) {
            //Hit target
            Debug.Log("Hit target");
        }
        else {
            //Hit something else
            Debug.Log("Hit something else");
        }
        Destroy(gameObject);
    }
}