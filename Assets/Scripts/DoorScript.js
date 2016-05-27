#pragma strict

var key = 0; //amount of keys you have
var dor : GameObject; //gameobject that is the door, add dor1 dor2 if needed
var nyckel : GameObject; //^except for key

function OnCollisionEnter(collision: Collision) 
    {
        if (collision.gameObject.tag == "key")//collision with object tag = key
        {
            key += 1;//add 1 to key
            Destroy(nyckel);//destroy the key object
        }
        if (key >= 1)//check if you have any keys
        {
            if (collision.gameObject.tag == "door")//are you coliding with door object
            {
                Destroy(dor);//destroy said door 
                key -= 1;//remove one key that you hold
            }
        }
    } 
