using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluecapsule : MonoBehaviour
{
    bool goUp;
    public float speed = 1;
  
// Start is called before the first frame update
void Start()
{
    StartCoroutine(SwitchDirection());
}

// Update is called once per frame
void Update()
{
    if (goUp)
    {
        transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
    }
    else
    {
        transform.position = transform.position - new Vector3(0, speed * Time.deltaTime, 0);
    }
}
IEnumerator SwitchDirection()
{
    while (gameObject.activeSelf)
    {
        yield return new WaitForSeconds(2f);
        goUp = !goUp;
    }

}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPicked();
        }
    }
    protected virtual void OnPicked()
    {
        Debug.Log("Hai preso: " + gameObject.name);

    }
}
