using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("NEXT LEVEL");
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(3);
            
            SceneManager.LoadScene(0);
        }

        StartCoroutine(Wait());

    }
}
