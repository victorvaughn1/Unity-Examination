using UnityEngine;

public class ShowCanvasOnTrigger : MonoBehaviour
{
    public GameObject canvasObject;

    private void Start()
    {
        if (canvasObject != null)
            canvasObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (canvasObject != null)
                canvasObject.SetActive(true);
        }
    }
}