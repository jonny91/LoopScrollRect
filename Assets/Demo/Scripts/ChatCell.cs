/*************************************************************************************
 *
 * 文 件 名:   ChatCell.cs
 * 描    述: 
 * 
 * 创 建 者：  洪金敏 
 * 创建时间：  2021-09-20 21:57:29
*************************************************************************************/

using UnityEngine;
using UnityEngine.UI;

public class ChatCell : MonoBehaviour
{
    public Text text;

    public void ScrollCellContent(string word)
    {
        if (text)
        {
            text.text = word;
        }
    }
}