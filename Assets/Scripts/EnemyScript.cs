using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent enemyNavMeshAgent;
    public Transform playerTransform;

    // Update is called once per frame
    private void Update()
    {
        enemyNavMeshAgent.SetDestination(playerTransform.position);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.rigidbody.transform == playerTransform)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("YouLostMenu");
        }
    }
}