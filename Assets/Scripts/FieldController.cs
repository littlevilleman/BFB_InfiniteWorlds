using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour {

    public int fieldSize = 1;

    public float getFieldWidth()
    {
        return GlobalUtils.FIELD_UNIT_WIDTH * fieldSize;
    }
    
    public float getFieldHeight()
    {
        return GlobalUtils.FIELD_UNIT_HEIGHT * fieldSize;
    }

}
