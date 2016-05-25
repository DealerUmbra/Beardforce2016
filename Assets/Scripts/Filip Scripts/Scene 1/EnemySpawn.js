#pragma strict

 var smoke : ParticleSystem;
 function Start () 
 {
     smoke = gameObject.GetComponent(ParticleSystem);
 }
 function OnTriggerEnter (other : Collider) 
 {
     if (other.gameObject.CompareTag ("Enemy")) 
     {
          gameObject.GetComponentInChildren(ParticleSystem).Play();

     }
 }