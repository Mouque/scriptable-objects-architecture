using UnityEngine;

public class DumbEnemy : MonoBehaviour
{
    public FloatReference MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * MoveSpeed.Value * Time.deltaTime;
        }
    }
}
