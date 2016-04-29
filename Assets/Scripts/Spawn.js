 var spawnTime : float = 0.0f;
  var maxTime : float = 500.0f;
   function Update() {
      if (spawnTime >= 30.0f) {
         Spawn();
      }
      if (spawnTime >= 300) { //i.e. reached 4 minutes and haven't done it yet
        Spawn();
        spawnTime = 0.0f;
      }
      spawnTime += Time.deltaTime; 
     }
     
  function Spawn() {
  //you can keep it like you have i think, but why invokerepeating then cancel? Just instantiate an enemy once here, forget the invoke repeating calls
 }