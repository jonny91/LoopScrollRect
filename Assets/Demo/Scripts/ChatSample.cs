/*************************************************************************************
 *
 * 文 件 名:   ChatSample.cs
 * 描    述: 
 * 
 * 创 建 者：  洪金敏 
 * 创建时间：  2021-09-20 22:21:59
*************************************************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatSample : MonoBehaviour
{
    public LoopScrollRect ScrollRect;
    public RectTransform ScrollRectContent;

    private List<string> _chats = new List<string>();

    public void AddChat()
    {
        var str = RandomWord();
        _chats.Add(str);
        ScrollRect.objectsToFill = _chats.ToArray();
        ScrollRect.totalCount = _chats.Count;
        ScrollRect.RefillCells();

        LayoutRebuilder.ForceRebuildLayoutImmediate(ScrollRectContent);
        Canvas.ForceUpdateCanvases();
    }

    private List<string> _speakerList = new List<string>() { "李白", "苏轼", "白居易" };

    private List<string> _words = new List<string>()
    {
        "天舟三号飞船交会对接空间站组合体",
        "牛肉价格和销量大涨",
        "新疆自治区博物馆现存一块1400年前的月饼，该月饼以小麦粉为原料，模压成型，烘烤制成，宝相花纹清晰可见，体现了当时高超的面点制作技艺。",
        "1986年8月，18岁的邵新宇在江苏靖江县中学加入中国共产党，并被免试保送华中工学院（后改名华中理工大学，现为华中科技大学）机制专业。在大学期间，他学习成绩优异，积极参与各类活动，曾担任全国学联副主席、湖北省学联副主席、校学生会主席。"
    };

    private string RandomWord()
    {
        return "<color=#ff0000>" + _speakerList[Random.Range(0, _speakerList.Count)] + "</color> : " +
               _words[Random.Range(0, _words.Count)];
    }
}