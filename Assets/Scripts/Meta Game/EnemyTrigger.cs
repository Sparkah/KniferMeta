using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    private Animator animatorPlayer;
    private Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponentInChildren<Animator>()!=null)
        {
            animatorPlayer = other.GetComponentInChildren<Animator>();
            animatorPlayer.SetTrigger("Attack");
            animator.SetTrigger("Die");
            animator.GetComponentInParent<BoxCollider>().enabled = false;
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(5f);
        animator.GetComponentInParent<BoxCollider>().enabled = true;
        Instantiate(gameObject, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
}
