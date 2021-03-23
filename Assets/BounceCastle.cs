 using UnityEngine;
 using System.Collections;
 
 public class BouncingEffect : MonoBehaviour {
     public float radius = 5.0F;
     public float power = 1000.0F;
 
     Vector3 epicentro;
 
     void Start() {
 
         Vector3 explosionPos = transform.position;
         epicentro = explosionPos;
     }
 
     void OnCollisionEnter(Collision collision) {
         if (collision.gameObject.tag == "Player") {
             GameObject player = GameObject.FindWithTag("Player");
             Rigidbody myplayer = player.AddComponent<Rigidbody>();                 
             myplayer.AddExplosionForce (power, epicentro, radius, 3.0F);
             Debug.Log("Player has collided with Bouncer");
         }
     }
 }