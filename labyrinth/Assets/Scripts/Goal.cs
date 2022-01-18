using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public WinConditions winScript;

    private void OnTriggerEnter(Collider other) {
        winScript.WinCondition();
    }
}
