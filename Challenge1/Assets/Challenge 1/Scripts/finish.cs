using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject col;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            col.SetActive(true);
            StartCoroutine(GameFinish());
        }
    }

    IEnumerator GameFinish()
    {
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 0;
    }
}
