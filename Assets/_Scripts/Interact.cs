using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject canvasInteract;
    [SerializeField] private Item fromInteract;
    private int count;
    
    private void OnEnable()
    {
        count = 0;
    }


    private void OnMouseDown()
    {
        count++;
        this.transform.localPosition = new Vector3(Random.Range(-8,8),Random.Range(-3,3),0);
        if (count > 10)
        {
            canvasInteract.SetActive(false);
            fromInteract.gameObject.SetActive(false);
        }
    }
}
