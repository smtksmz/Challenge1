using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacles : MonoBehaviour
{
    public GameObject _canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _canvas.SetActive(true);
            StartCoroutine(TryAgain());
        }
    }
    public void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

    IEnumerator TryAgain()
    {
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 0;
    }
}
