using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Orc : Character {
    protected override void Affect(IEnumerable<Character> characters) {
        Debug.Log($"���������� ���������� ���� �� {characters.Count()} ����������");
    }
}