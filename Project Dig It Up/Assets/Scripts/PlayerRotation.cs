using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
   public Transform tr;
   private Vector3 posLast;
   private Vector3 vel;

   private void Awake()
   {
      posLast = tr.position;
   }

   private void Update()
   {
      vel = tr.position - posLast;
      if(vel.magnitude>0.01f)
         tr.localEulerAngles = new Vector3(tr.localEulerAngles.x, Mat.angle(vel.x,vel.z), tr.localEulerAngles.z);
      posLast = tr.position;
   }
}
