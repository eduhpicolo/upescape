using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform actualPosition;
    private Vector3 destination;
    private float destinationDistance;      
    public float moveSpeed = 20f;
    public Animator anim;
    public string tagCollider;
    public bool onMove; 
    void Start()
    {
        actualPosition = transform;                            
        destination = actualPosition.position;         
    }

    void Update()
    {
        Moving();
    }

    void Moving()
    {
        destinationDistance = Vector3.Distance(destination, actualPosition.position);
        
        if (Input.GetMouseButtonDown(0))
        {
            Plane playerPlane = new Plane(Vector3.back, actualPosition.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float hitdist = 0.0f;

            if (playerPlane.Raycast(ray, out hitdist))
            {
                Vector3 targetPoint = ray.GetPoint(hitdist);
                destination = ray.GetPoint(hitdist);
                Quaternion targetRotation = Quaternion.LookRotation(new Vector3(targetPoint.x,0,0) - new Vector3(transform.position.x, 0,0));
                anim.gameObject.transform.localScale = new Vector3(targetRotation.y > 0 ? 5 : -5,5,1);
            }
        }
        if (destinationDistance > .05f)
        {
            actualPosition.position = Vector3.MoveTowards(actualPosition.position, destination, moveSpeed * Time.deltaTime);   
            anim.SetInteger("state",1);
            onMove = true;
        }
        else
        {
            anim.SetInteger("state",0);
            onMove = false;
        }
    }
    

    void OnTriggerStay(Collider collision)
    {
        var hit = collision.gameObject;
        tagCollider = hit.name;
    }
    
    void OnTriggerExit(Collider collision)
    {
        tagCollider = "";
    }
}