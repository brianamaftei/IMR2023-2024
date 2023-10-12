using UnityEngine;

public class DetectionScript2 : MonoBehaviour
{
    public GameObject target;
    public float attackDistance = 80;
    private Animator animator;
    public bool isAttacking = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("Scriptul domnisoara pogani a fost citit ---------------------------------------------------------!");

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
                Debug.Log("atac pogani atac pogani atac pogani atac pogani atac pogani atac pogani atac pogani atac pogani! valaore isAttacking: " + isAttacking);

            }
            else
            {
                animator.SetBool("isAttacking", false);
                Debug.Log("Pace pogani pace pogani pace pogani pace pogani pace pogani pace pogani acest cactus: " + transform.position+ "celalalt cactus:  " + target.transform.position+ "distanta: " + distance + " dsitanta minima: " + attackDistance);

            }
        }
    }
}
