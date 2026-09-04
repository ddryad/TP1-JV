using UnityEngine;

public class PorteSortie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : ignorer tout objet qui n'est pas le joueur.
        if (!autre.CompareTag("Player"))
        {
            return;
        }
        // TODO : annoncer la réussite et faire disparaître le joueur.
        Debug.Log("MISSION RÉUSSIE !");
        Destroy(autre.gameObject);
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Replacez les lignes, puis ajoutez les accolades manquantes.
     *
     * 
     * 
     * 
     * 
     */
}
