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
            
            try{
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            } catch{
                SceneManager.LoadScene(0);
            }
        }

        StartCoroutine(Wait());

    }
}
