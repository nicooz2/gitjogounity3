using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDash : MonoBehaviour
{
    [SerializeField] private Rigidbody2D b_rigidbody2D;

    private bool PodeDash = true;
    private bool EstaComDash;
    private float DashForca = 100f;
    private float DashTempo = 0.8f;
    private float DashIntervalo = 1f;

    [SerializeField] private TrailRenderer tr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EstaComDash)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && PodeDash)
        {
            StartCoroutine(Dash());
        }
    }

    private void FixedUpdate()
    {
        if (EstaComDash)
        {
            return;
        }
    }

    private IEnumerator Dash()
    {
        PodeDash = false;
        EstaComDash = true;
        float originalGravity = b_rigidbody2D.gravityScale;
        b_rigidbody2D.gravityScale = 0f;
        b_rigidbody2D.velocity = new Vector2(transform.localScale.x * DashForca, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(DashTempo);
        tr.emitting = false;
        b_rigidbody2D.gravityScale = originalGravity;
        EstaComDash = false;
        yield return new WaitForSeconds(DashIntervalo);
        PodeDash = true;

    }
}
