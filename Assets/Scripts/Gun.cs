using UnityEngine;

public class Gun : MonoBehaviour
{
    public static Gun instance;

    public GameObject bullet;
    public float fireRate;
    public float fireCounter;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireCounter > 0)
        {
            fireCounter -= Time.deltaTime;
        }
    }
}
