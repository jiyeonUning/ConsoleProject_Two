namespace ConsoleProject_Two.Items
{

    public delegate Item ListSave(ItemType type);

    public class ItemList
    {
        public static Item CreateScissors(ItemType type)
        {
            if (type == ItemType.재봉가위)
            {
                Item scissors = new Item();
                scissors.name = "재봉 가위";
                scissors.have = true;
                return scissors;
            }
            else
            {
                Console.WriteLine();
                return null;
            }
        }

        public static Item CreateSew(ItemType type)
        {
            if (type == ItemType.재봉키트)
            {
                Item sew = new Item();
                sew.name = "재봉 키트";
                sew.have = true;
                return sew;
            }
            else
            {
                Console.WriteLine();
                return null;
            }
        }
    }


}
