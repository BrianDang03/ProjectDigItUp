using UnityEngine;

public class Mat
{
   public static float angle(Vector2 v2)
   {
      return(angle(v2.x, v2.y));
   }
   public static float angle(float x, float y)
   {
      float angle = Mathf.Atan2(x,y)*Mathf.Rad2Deg;
      if(angle < 0)
         angle += 360;
      return(angle);
   }
   public static float angleY(Vector3 v3a, Vector3 v3b)
   {
      return(angle(new Vector2(v3b.x-v3a.x, v3b.z-v3a.z)));
   }
   public static float angleDiff(float a, float b)
   {
      if(a>b)
         return(a-b);
      else
         return(b-a);
   }
   public static Vector2 rotateV2(Vector2 v2, float angle)
   {
      angle = angle * Mathf.Deg2Rad;
      float sin = Mathf.Sin(angle);
      float cos = Mathf.Cos(angle);
      return new Vector2((v2.x*cos) + (v2.y*sin), (v2.y*cos) - (v2.x*sin));
   }
  
   public static float horiDistance(Vector3 a, Vector3 b)
   {
      return(Vector2.Distance(new Vector2(a.x,a.z), new Vector2(b.x,b.z)));
   }

   public static Vector3 clampV3(Vector3 v3, Vector3 v3Min, Vector3 v3Max)
   {
      if(v3.x < v3Min.x)
         v3.x = v3Min.x;
      else if(v3.x > v3Max.x)
         v3.x = v3Max.x;
      if(v3.y < v3Min.y)
         v3.y = v3Min.y;
      else if(v3.y > v3Max.y)
         v3.y = v3Max.y;
      if(v3.z < v3Min.z)
         v3.z = v3Min.z;
      else if(v3.z > v3Max.z)
         v3.z = v3Max.z;
      return(v3);
   }
   public static Vector3Int clampV3Int(Vector3Int v3, Vector3Int v3Min, Vector3Int v3Max)
   {
      if(v3.x < v3Min.x)
         v3.x = v3Min.x;
      else if(v3.x > v3Max.x)
         v3.x = v3Max.x;
      if(v3.y < v3Min.y)
         v3.y = v3Min.y;
      else if(v3.y > v3Max.y)
         v3.y = v3Max.y;
      if(v3.z < v3Min.z)
         v3.z = v3Min.z;
      else if(v3.z > v3Max.z)
         v3.z = v3Max.z;
      return(v3);
   }
   public static Vector3Int roundV3(Vector3 v3)
   {
      return(new Vector3Int(Mathf.RoundToInt(v3.x), Mathf.RoundToInt(v3.y), Mathf.RoundToInt(v3.z)));
   }
   public static Vector2 flattenV3Y(Vector3 v3)
   {
      return(new Vector2(v3.x, v3.z));
   }
}