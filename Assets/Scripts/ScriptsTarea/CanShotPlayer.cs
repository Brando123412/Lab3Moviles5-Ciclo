using UnityEngine;

public class CanShotPlayer : MonoBehaviour
{
   
    [SerializeField] Touch touch;
    [SerializeField] ObjectPolling pollingReferences;
    private void Update()
    {
        if (Input.touchCount > 0)
        {

            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                InvokeRepeating("Disparo", 0f, 0.5f);
            }
            if (touch.phase == TouchPhase.Ended)
            {
                CancelInvoke("Disparo");
            }
        }
    }
    void Disparo()
    {
        pollingReferences.GetObject(this.transform.position);
    }
}
