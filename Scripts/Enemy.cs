using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform target;
    private Vector3 direction;
    public float enemySpeed = 1f;

    public AudioClip getHitAudio;

    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        direction = (player.transform.position - transform.position);
        //rb.velocity = new Vector2(direction.x, direction.y).normalized * enemySpeed;
        transform.Translate(direction.normalized * enemySpeed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, player.transform.position) <= 0.4f)
        {
            PlayerStats.Lives--;
            AudioSource.PlayClipAtPoint(getHitAudio, transform.position);
            Handheld.Vibrate();
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
