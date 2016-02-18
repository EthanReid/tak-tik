 var MoveSpeed : float = 2;
 var Player : Transform;
 var MaxDist = 10;
 var MinDist = 5;
 
 
 function Update () 
 {
     transform.LookAt(Player);
 
 
 
    if(Vector3.Distance(transform.position,Player.position) >= MinDist){
          transform.position += transform.forward*MoveSpeed*Time.deltaTime;
          
     }
     }