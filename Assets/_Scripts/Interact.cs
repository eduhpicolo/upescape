using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    private int count;
    private void OnMouseDown()
    {
        count++;
        this.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(Random.Range(-20,20),0), ForceMode.Force);
        if (count > 10)
            SceneManager.LoadScene(0);
    }
}
