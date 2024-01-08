using UnityEngine;

public class Echelle : MonoBehaviour
{
    public float Speed = 5f;
    public float delaiReinitialisation = 5f;

    private void OnTriggerStay(Collider other)
    {

            float mouvementVertical = Input.GetAxis("Vertical");
            Vector3 mouvement = new Vector3(0f, mouvementVertical, 0f) * Speed * Time.deltaTime;
            other.transform.Translate(mouvement);
            
            if (mouvementVertical == 0f)
            {
                StartCoroutine(ReinitialiserPositionVerticale(other.transform));
            }
    }
    
    private System.Collections.IEnumerator ReinitialiserPositionVerticale(Transform playerTransform)
    {
        yield return new WaitForSeconds(delaiReinitialisation);
        
        Vector3 nouvellePosition = new Vector3(playerTransform.position.x, 0f, playerTransform.position.z);
        playerTransform.position = nouvellePosition;
    }
}
