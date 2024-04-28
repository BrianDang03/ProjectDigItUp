using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public static CollisionHandler Instance;
    public event EventHandler OnOrePickUp;

    private void Awake()
    {
        Instance = this;
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Asteroid")
        {
            string curretnSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(curretnSceneName);
        }

        if (other.gameObject.tag == "Ore")
        {
            OnOrePickUp?.Invoke(this, EventArgs.Empty);
            Destroy(other.gameObject);
        }
    }
}
