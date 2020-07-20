
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public GameObject planet;

    public float maxGravity;
    public float maxGravityDist;

    float lookAngle;
    Vector3 lookDirection;

    public Rigidbody2D rb;


    void Update()
    {
        float dist = Vector2.Distance(planet.transform.position, transform.position);

        Vector3 v = planet.transform.position - transform.position;
        rb.AddForce(v.normalized * (1.0f - dist / maxGravityDist) * maxGravity);

        lookDirection = planet.transform.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);
  
    }

}
