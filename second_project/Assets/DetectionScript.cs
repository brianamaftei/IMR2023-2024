using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    public GameObject target;
    public float attackDistance = 80;
    private Animator animator;
    public bool isAttacking = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("Scriptul cereale a fost citit ---------------------------------------------------------!");

    }

    private void Update()
    {
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);

            // Debug.Log("***********************************************************88!");

            if (distance <= attackDistance)
            {
                animator.SetBool("isAttacking", true);
                Debug.Log("atac cereale atac cereale atac cereale atac cereale atac cereale atac cereale atac cereale atac cereale!valaore isAttacking: " + isAttacking);


            }
            else
            {
                animator.SetBool("isAttacking", false);
                Debug.Log("pace cereale pace cereale pace cereale pace cereale pace cereale pace cereale acest cactus: " + transform.position+ "celalalt cactus:  " + target.transform.position + " distanta: " + distance + " dsitanta minima: " + attackDistance);
            }
        }
    }
}
