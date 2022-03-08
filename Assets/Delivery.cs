using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public bool isPackaged = false;

    float destroyDelay = 0.2f;

    [SerializeField] Color32 hasPackageColor = new Color32();
    [SerializeField] Color32 noPackageColor = new Color32();

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "package")
        {
            if (!isPackaged)
            {
                isPackaged = true;
                Debug.Log("Package taked");
                Destroy(other.gameObject, destroyDelay);
                spriteRenderer.color = hasPackageColor;
            }


        }
        else if (other.gameObject.tag == "deliverSide")
        {
            if (isPackaged)
            {
                isPackaged = false;
                Debug.Log("Package delivered");
                spriteRenderer.color = noPackageColor;
            }
            else
            {
                Debug.Log("no package");
            }
        }
    }


}
