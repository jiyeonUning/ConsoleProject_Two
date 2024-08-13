namespace ConsoleProject_Two.Items
{
    public class Item
    {
        ItemBuilder itemBuilder = new ItemBuilder();

        public void itemScissors()
        {
            itemBuilder.id = 1;
            itemBuilder.name = "재봉 가위";
            itemBuilder.explain = "천을 자르는 용도의 가위. 끝이 매우 날카롭다.";
        }

        public void itemSew()
        {
            itemBuilder.id = 2;
            itemBuilder.name = "재봉 키트";
            itemBuilder.explain = "10살 아이 손바닥 만한 크기의 재봉키트. 소량의 바늘과 실이 들어있다.";
        }
    }
}
