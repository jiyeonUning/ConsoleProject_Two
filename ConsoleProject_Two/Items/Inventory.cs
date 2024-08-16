namespace ConsoleProject_Two.Items
{
    public class Inventory
    {
        // 교수님이 작성하신 지난 과제풀이 중
        // 동적 인벤토리 구현 과제 참고하였습니다

        // 아이템 추가 미구현 

        public const int MAXitem = 9;
        private List<ItemList> items;
        public int itemCount => items.Count;

        public Inventory()
        {
            items = new List<ItemList>(9);
        }

        // ===============================================

        public bool AddItem(ItemList itemList)
        {
            if (items.Count == MAXitem) return false;
            items.Add(itemList); return true;
        }

        public bool RemoveItem(int index)
        {
            if (index < 0 || items.Count <= index) return false;
            items.RemoveAt(index); return true;
        }

        public void ShowAllItems()
        {
            if (items.Count == 0) { Console.Write(" "); }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (true)
                    {
                        Console.Write($"{items[i]}");
                    }                
                }
            }
        }
    }
}
