using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed ;
    [SerializeField] Renderer renderer1;

    void Start()
    {
        renderer1 = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        renderer1.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
