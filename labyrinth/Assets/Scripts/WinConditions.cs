using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinConditions : MonoBehaviour {
    public GameObject p;
    public bool isWinning = false;

    public void WinCondition() {
        Debug.Log("You Win");

        p.gameObject.SetActive(true);
    }
}
