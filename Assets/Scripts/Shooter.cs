using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _template;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_template, _shootPoint);
        }

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began) 
            {
                Instantiate(_template, _shootPoint);
            }
        }
    }
}
