namespace ConsoleProject_Two.Items
{
    public class Item
    {
        ItemBuilder itemBuilder = new ItemBuilder();

        public void Scissors()
        {
            itemBuilder.id = 1;
            itemBuilder.name = "재봉 가위";
            itemBuilder.explain = "천을 자르는 용도의 가위. 끝이 매우 날카롭다.";
        }
    }
}
