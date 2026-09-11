using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class MouvementRobot : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;


    private Rigidbody2D corps;
    private Vector2 direction;
    private Animator animator;

    private void Awake()
    {
        corps = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // TODO : reconstruire la lecture des commandes et la direction normalisée.
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector2(horizontal, vertical).normalized;
    }

    private void FixedUpdate()
    {
        // TODO : déplacer le robot en tenant compte du temps physique.
        animator = GetComponent<Animator>();
        corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
        animator.SetBool("EnMouvement", direction.sqrMagnitude > 0.01f);
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Les lignes ne sont pas dans le bon ordre.
     *
     * 
     * 
     * 
     * 
     */
}
