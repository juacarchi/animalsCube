using UnityEngine;
using UnityEngine.EventSystems;
public class DragObject : MonoBehaviour, IDragHandler, IDropHandler
{
    public float zValue = 1;
    SpriteRenderer originalSprite;
    public Rigidbody2D rb;
    public BoxCollider2D bx;
    GameObject fxStars;
    bool isDrag;
    public float xMin, xMax;
    public float yMin, yMax;

    private void Awake()
    {
        originalSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        bx = GetComponent<BoxCollider2D>();
        originalSprite.sortingOrder = 1;
        xMin = -6.9f;
        xMax = 6.9f;
        yMin = -4.6f;
        yMax = 4.6f;
    }
    private void Start()
    {
        fxStars = GameManager.instance.fx_Stars;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDrag)
        {
            SFX2Manager.instance.PlaySFX(SFX2Manager.instance.drag);
            isDrag = true;
        }
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = zValue;
        Vector3 point = Camera.main.ScreenToWorldPoint(mousePosition);
       //WEBGL
        //point.x = Mathf.Clamp(point.x, xMin, xMax);
        //point.y = Mathf.Clamp(point.y, yMin, yMax);
        transform.position = point;
        originalSprite.sortingOrder = 2;
        rb.isKinematic = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        isDrag = false;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        originalSprite.sortingOrder = 1;
        rb.isKinematic = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (this.gameObject.CompareTag("t_movil"))
        {
            if (other.gameObject.CompareTag("T"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.t_sound);
            }
        }
        if (this.gameObject.CompareTag("i_movil"))
        {
            if (other.gameObject.CompareTag("I"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.i_sound);
            }
        }
        if (this.gameObject.CompareTag("g_movil"))
        {
            if (other.gameObject.CompareTag("G"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.g_sound);
            }
        }
        if (this.gameObject.CompareTag("r_movil"))
        {
            if (other.gameObject.CompareTag("R"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.r_sound);
            }
        }
        if (this.gameObject.CompareTag("e_movil"))
        {
            if (other.gameObject.CompareTag("E"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.e_sound);
            }
        }
        if (this.gameObject.CompareTag("m_movil"))
        {
            if (other.gameObject.CompareTag("M"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.m_sound);
            }
        }
        if (this.gameObject.CompareTag("o_movil"))
        {
            if (other.gameObject.CompareTag("O"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.o_sound);
            }
        }
        if (this.gameObject.CompareTag("n_movil"))
        {
            if (other.gameObject.CompareTag("N"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.n_sound);
            }
        }
        if (this.gameObject.CompareTag("l_movil"))
        {
            if (other.gameObject.CompareTag("L"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.l_sound);
            }
        }
        if (this.gameObject.CompareTag("b_movil"))
        {
            if (other.gameObject.CompareTag("B"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.b_sound);
            }
        }
        if (this.gameObject.CompareTag("a_movil"))
        {
            if (other.gameObject.CompareTag("A"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.a_sound);
            }
        }
        if (this.gameObject.CompareTag("u_movil"))
        {
            if (other.gameObject.CompareTag("U"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.u_sound);
            }
        }
        if (this.gameObject.CompareTag("c_movil"))
        {
            if (other.gameObject.CompareTag("C"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.c_sound);
            }
        }
        if (this.gameObject.CompareTag("d_movil"))
        {
            if (other.gameObject.CompareTag("D"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.d_sound);
            }
        }
        if (this.gameObject.CompareTag("f_movil"))
        {
            if (other.gameObject.CompareTag("F"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.f_sound);
            }
        }
        if (this.gameObject.CompareTag("s_movil"))
        {
            if (other.gameObject.CompareTag("S"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.s_sound);
            }
        }
        if (this.gameObject.CompareTag("v_movil"))
        {
            if (other.gameObject.CompareTag("V"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.v_sound);
            }
        }
        if (this.gameObject.CompareTag("z_movil"))
        {
            if (other.gameObject.CompareTag("Z"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.z_sound);
            }
        }
        if (this.gameObject.CompareTag("j_movil"))
        {
            if (other.gameObject.CompareTag("J"))
            {
                InterchangeLetter(other);
                SFXManager.instance.PlaySFX(SFXManager.instance.j_sound);
            }
        }
    }

    public void InterchangeLetter(Collision2D other)
    {
        Success();
        GameManager.instance.SumaLetraCorrecta();
        Vector3 posCube = other.transform.position;
        SpriteRenderer otherSprite = other.gameObject.GetComponent<SpriteRenderer>();
        otherSprite.sprite = originalSprite.sprite;
        GameObject instantiateStar = Instantiate(fxStars, posCube, Quaternion.Euler(-90, 0, 0));
        Destroy(instantiateStar, 3f);
        Destroy(this.gameObject);
        bx.enabled = false;

    }
    public void Fail()
    {
        SFX2Manager.instance.PlaySFX(SFX2Manager.instance.fail);
    }
    public void Success()
    {
        SFX2Manager.instance.PlaySFX(SFX2Manager.instance.succes);
    }

}
