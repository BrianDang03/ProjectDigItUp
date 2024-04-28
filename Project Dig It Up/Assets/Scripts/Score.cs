using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    int score = 0;
    private void Start()
    {
        CollisionHandler.Instance.OnOrePickUp += CollisionHandler_OnOrePickUp;
    }

    private void CollisionHandler_OnOrePickUp(object sender, EventArgs e)
    {
        scoreText.text = $"Score: {++score}";
    }
}
