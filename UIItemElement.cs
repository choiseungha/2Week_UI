using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Du3Project
{
	public class UIItemElement : MonoBehaviour
	{
        [Header("[자료들]")]
        public Text ItemLabel = null;
        public Text ItemScore = null;
        public Image ItemIcon = null;

        [Header("[데이터용Index]")]
        public int ItemIndex = -1;


        public void UpdateItem(int p_index, Sprite p_item = null, string p_label = "happy")
        {
            ItemIndex = p_index;

            ItemScore.text = ItemIndex.ToString();
            ItemIcon.sprite = p_item;
            ItemLabel.text = p_label;
        }

        void Start()
		{
			
		}

		//void Update()
		//{
			
		//}
	}
}