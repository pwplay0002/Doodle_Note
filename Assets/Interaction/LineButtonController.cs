using UnityEngine;

public class LineButtonController : MonoBehaviour
{
    public GameObject lineObject;
    public GameObject pivot;

    private LineRenderer lineRenderer;

    private bool is_visit = false;
    private bool is_change = false;

    private Vector3 ChangeLine;
    private Vector3 OriLine;

    private Animator Anim;

    void Start()
    {
        lineRenderer = lineObject.GetComponent<LineRenderer>();
        ChangeLine = new Vector3(lineRenderer.GetPosition(0).y, lineRenderer.GetPosition(0).x * -1, 0);
        OriLine = new Vector3(lineRenderer.GetPosition(0).x, lineRenderer.GetPosition(0).y, 0);
        Anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box") && !is_visit)
        {
            is_visit = true;
            RotateLine();
            Anim.SetBool("is_ButtonDown", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Box") && is_visit)
        {
            is_visit = false;
            RotateLine();
            Anim.SetBool("is_ButtonDown", false);
        }
    }

    void RotateLine()
    {

        if (!is_change)
        {
            pivot.transform.Rotate(Vector3.forward * -90f);
            lineRenderer.SetPosition(0, ChangeLine);
            lineRenderer.SetPosition(1, ChangeLine);

            

            is_change = true;
        }
        else
        {
            pivot.transform.Rotate(Vector3.forward * 90f);
            lineRenderer.SetPosition(0, OriLine);
            lineRenderer.SetPosition(1, OriLine);

            is_change = false;
        }

        
    }
}
