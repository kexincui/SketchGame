using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MaxHealth;
    private Transform healthBarObj;
    private HealthBar healthBar;

    private float health;
    // private readonly float EPSILON = 1e-4f;

    // TODO: health and show health bar
    // TODO: collision with the attack and reduce the health, collision to the endpoint.

    // Start is called before the first frame update
    void OnEnable()
    {
        health = MaxHealth;
        healthBarObj = gameObject.transform.Find("HealthBar");
        healthBar = healthBarObj.GetComponent<HealthBar>();
        healthBarObj.gameObject.SetActive(false);
    }

    // Update is called once per frame
    // void Update()
    // {
    //    health--;
    //    healthBar.gameObject.SetActive(true);
    //    healthBar.setSize(health / MaxHealth);
    //    if (System.Math.Abs(health) < EPSILON)
    //    {
    //        gameObject.SetActive(false);
    //    }
    // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Collide Enter");
        if (!gameObject.activeSelf) return;

        if (collision.CompareTag("Finish"))
        {
            // TODO: Health Reduction
            // Debug.Log("Enter");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Debug.Log("Collide Exit");
        if (collision.CompareTag("Finish"))
        {
            //TODO: delete object.
            // gameObject.SetActive(false);
            GameObject.Find("GameManagement").GetComponent<EnemyManage>().DeleteEnemy(gameObject);
            Destroy(gameObject);
            // Debug.Log("Exit");
            //EnemyManagerScript.Instance.DeleteEnemy(gameObject);
            //Pool.Instance.DeactivateObject(gameObject);
        }
    }
}