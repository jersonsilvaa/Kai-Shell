using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collision : MonoBehaviour {
    #region Layers and collision of the game
    [Header("Layers")]
    public LayerMask groundLayer;

    [Space]

    [Header("Booleans")]
    public bool onGround;

    [Space]

    [Header("Collision")]
    [SerializeField] private Vector2 collSize = new Vector2(1f, .5f);
    public Vector2 bottomOffset;
    #endregion

    void Update () {
        #region Check collision
        onGround = Physics2D.OverlapBox((Vector2) transform.position + bottomOffset, collSize, 0f, groundLayer);
        #endregion
    }
    #region Draw gizmos
    void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube((Vector2) transform.position + bottomOffset, collSize);
    }
    #endregion
}