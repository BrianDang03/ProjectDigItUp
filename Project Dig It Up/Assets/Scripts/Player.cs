using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player Instance;

    private void Awake()
    {
        Instance = this;
    }

    public static Vector3 GetPlayerPosition()
    {
        return Instance.transform.position;
    } 
}
