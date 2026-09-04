using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : filtrer l'objet touché.
        if (!autre.CompareTag("Player"))
        {
            return;
        }
        // TODO : empêcher le déplacement si PointDepart est absent.
        if (pointDepart == null)
        {
            Debug.LogError("Le point de départ n'est pas assigné.");
            return;
        }
        // TODO : retourner le joueur à sa position initiale.
        Debug.Log("Le robot retourne au point de départ.");
        autre.transform.position = pointDepart.position;
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * La ligne return; doit être utilisée aux deux endroits appropriés.
     *
     * 
     * 
     * 
     * 
     * 
     * 
     */
}
