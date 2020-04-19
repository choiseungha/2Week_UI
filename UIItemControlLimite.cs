﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Du3Project
{
    [RequireComponent(typeof(InfiniteScroll))]
    public class UIItemControlLimite : MonoBehaviour, IInfiniteScrollSetup
    {
        public Sprite[] ItemImage_List ;
        public string[] labels;
        public int ItemCount = 20;

        public void OnPostSetupItems()
        {
            InfiniteScroll scroll = GetComponent<InfiniteScroll>();
            scroll.onUpdateItem.AddListener(OnUpdateItem);
            GetComponentInParent<ScrollRect>().movementType = ScrollRect.MovementType.Elastic;


            // content size 수정하기
            var rectTransform = GetComponent<RectTransform>();
            var delta = rectTransform.sizeDelta;
            if(scroll.DirectionVal == InfiniteScroll.Direction.Vertical)
            {
                delta.y = scroll.itemScale * ItemCount;
                rectTransform.sizeDelta = delta;
            }
            else
            {
                delta.x = scroll.itemScale * ItemCount;
                rectTransform.sizeDelta = delta;
            }
            
        }

        public void OnUpdateItem(int itemCount, GameObject obj)
        {
            UIItemElement uiitem = obj.GetComponent<UIItemElement>();

            // 사이즈 지정
            if(itemCount >= 0
                && itemCount < ItemCount )
            {
                uiitem.gameObject.SetActive(true);
                uiitem.UpdateItem(itemCount, ItemImage_List[itemCount], labels[itemCount]);
            }
            else
            {
                uiitem.gameObject.SetActive(false);
            }

            
        }

        public void DirectUpdate(GameObject obj)
        {
        }

        void Start()
		{
			
		}

		//void Update()
		//{
			
		//}
	}
}